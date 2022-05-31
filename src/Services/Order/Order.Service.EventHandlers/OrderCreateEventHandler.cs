using MediatR;
using Microsoft.Extensions.Logging;
using Order.Domain;
using Order.Persistence.Database;
using Order.Service.EventHandlers.Commands;
using Order.Service.Proxies.Catalog;
using Order.Service.Proxies.Catalog.Commands;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Order.Service.EventHandlers
{
    public class OrderCreateEventHandler :
            INotificationHandler<OrderCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<OrderCreateEventHandler> _logger;
        private readonly ICatalogProxy _catalogProxy;

        public OrderCreateEventHandler(
            ApplicationDbContext context,
            ICatalogProxy catalogProxy,
            ILogger<OrderCreateEventHandler> logger)
        {
            _context = context;
            _catalogProxy = catalogProxy;
            _logger = logger;
        }

        public async Task Handle(OrderCreateCommand notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- New order creation started");
            var entry = new Domain.Order();

            using (var trx = await _context.Database.BeginTransactionAsync())
            {
                // 01. Prepare detail
                _logger.LogInformation("--- Preparing detail");
                PrepareDetail(entry, notification);

                // 02. Prepare header
                _logger.LogInformation("--- Preparing header");
                PrepareHeader(entry, notification);

                // 03. Create order
                _logger.LogInformation("--- Creating order");
                await _context.AddAsync(entry);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"--- Order {entry.OrderId} was created");

                // 04. Update Stocks
                _logger.LogInformation("--- Updating stock");

                try
                {
                    await _catalogProxy.UpdateStockAsync(new ProductInStockUpdateCommand
                    {
                        Items = notification.Items.Select(x => new ProductInStockUpdateItem
                        {
                            Action = ProductInStockAction.Substract,
                            ProductId = x.ProductId,
                            Stock = Convert.ToInt16(x.Quantity)
                        })
                    });
                }
                catch (Exception err)
                {
                    _logger.LogError("Order couldn't be created because some of the products don't have enough stock");
                    throw new Exception(err.ToString());
                }

                // Lógica para actualizar el Stock
                await trx.CommitAsync();
            }

            _logger.LogInformation("--- New order creation ended");
        }

        private void PrepareDetail(Domain.Order entry, OrderCreateCommand notification)
        {
            entry.Items = notification.Items.Select(x => new OrderDetail
            {
                ProductId = x.ProductId,
                SecuenceInOrder = x.SecuenceInOrder,
                Quantity = x.Quantity,
                UnitPrice = x.UnitPrice,
                SubTotal = x.SubTotal,
                Ice = x.Ice,
                Iva = x.Iva,
                Discount = x.Discount,
                Total = x.Total
            }).ToList();
        }

        private void PrepareHeader(Domain.Order entry, OrderCreateCommand notification)
        {
            // Header information
            entry.Status = Common.Enums.OrderStatus.Pending;
            entry.PaymentType = notification.PaymentType;
            entry.ClientId = notification.ClientId;
            entry.Salesman = notification.Salesman;
            entry.DocumentType = notification.DocumentType;
            entry.Description = notification.Description;
            entry.DocumentNumber = notification.DocumentNumber;
            entry.Reference = notification.Reference;
            entry.Autorization = notification.Autorization;
            entry.AttachedFilePath = notification.AttachedFilePath;
            entry.AdditionalDiscount = notification.AdditionalDiscount;
            entry.DueDate = notification.DueDate;
            entry.CreatedAt = DateTime.UtcNow;

            // Sum
            entry.Total = entry.Items.Sum(x => x.Total);
        }
    }
}
