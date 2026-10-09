using PAW.Web.Models;

namespace PAW.Web.Services
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetProductsAsync();
    }

    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var products = await _httpClient.GetFromJsonAsync<List<ProductViewModel>>("api/Products");
            return products ?? new List<ProductViewModel>();
        }
    }
}