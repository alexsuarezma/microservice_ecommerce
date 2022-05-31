using Order.Service.Proxies.Catalog.Commands;
using System.Text;
using System.Threading.Tasks;
using Api.Gateway.Proxies;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;

namespace Order.Service.Proxies.Catalog
{
    public class CatalogProxy : ICatalogProxy
    {
        private readonly ApiUrls _apiUrls;
        private readonly HttpClient _httpClient;

        public CatalogProxy(
            IOptions<ApiUrls> apiUrls,
            HttpClient httpClient
        )
        {
            _apiUrls = apiUrls.Value;
            _httpClient = httpClient;
        }

        public async Task UpdateStockAsync(ProductInStockUpdateCommand command)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(command),
                Encoding.UTF8,
                "application/json"
            );

            var request = await _httpClient.PutAsync(_apiUrls.CatalogUrl + "v1/stocks", content);
            request.EnsureSuccessStatusCode();
        }
    }
}
