using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Options;
using Order.Service.Proxies.Catalog.Commands;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace Order.Service.Proxies.Catalog
{
    public class CatalogQueueProxy : ICatalogProxy
    {
        private readonly string _connectionString;
        static string queueName = "invoice-update-stock";

        public CatalogQueueProxy(
            IOptions<AzureServiceBus> azure
        )
        {
            _connectionString = azure.Value.ConnectionString;
        }

        //public async Task UpdateStockAsync(ProductInStockUpdateCommand command)
        //{
        //    client = new ServiceBusClient(_connectionString);
        //    sender = client.CreateSender(queueName);

        //    // create a batch 
        //    using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

        //    // try adding a message to the batch
        //    if (!messageBatch.TryAddMessage(new ServiceBusMessage(JsonSerializer.Serialize(command))))
        //    {
        //        // if it is too large for the batch
        //        throw new Exception($"The message  is too large to fit in the batch.");
        //    }

        //    try
        //    {

        //        await sender.SendMessagesAsync(messageBatch);
        //    }
        //    finally
        //    {
        //        await sender.DisposeAsync();
        //        await client.DisposeAsync();
        //    }

        //}

        public async Task UpdateStockAsync(ProductInStockUpdateCommand command)
        {
            var options = new ServiceBusClientOptions { EnableCrossEntityTransactions = true };
            await using var client = new ServiceBusClient(_connectionString, options);

            ServiceBusSender sender = client.CreateSender(queueName);
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
            
            // try adding a message to the batch
            if (!messageBatch.TryAddMessage(new ServiceBusMessage(JsonSerializer.Serialize(command))))
            {
                // if it is too large for the batch
                throw new Exception($"The message  is too large to fit in the batch.");
            }


            ServiceBusReceiver receiver = client.CreateReceiver(queueName);
            ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveMessageAsync();


            using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                await receiver.CompleteMessageAsync(receivedMessage);
                await sender.SendMessagesAsync(messageBatch);
                ts.Complete();
            }
        }
    }
}
