using EduSys.Core.DTOs;

namespace EduSys.Web.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;
        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductWithCategoryDto>> GetProductWithCategoryAsync()
        {
            var responce = await _httpClient.GetFromJsonAsync<List<ProductWithCategoryDto>>("products/GetProductWithCategory");
            return responce;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var responce = await _httpClient.GetFromJsonAsync<ProductDto>($"products/{id}");
            return responce;
        }

        public async Task<ProductDto> SaveAsync(ProductDto newProduct)
        {
            var responce = await _httpClient.PostAsJsonAsync<ProductDto>("products", newProduct);
            if (!responce.IsSuccessStatusCode)
                return null;
            var responceBody = await responce.Content.ReadFromJsonAsync<ProductDto>();
            return responceBody;
        }

        public async Task<bool> UpdateAsync(ProductDto newProduct)
        {
            var responce = await _httpClient.PutAsJsonAsync("products", newProduct);
            return responce.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var responce = await _httpClient.DeleteAsync($"products{id}");
            return responce.IsSuccessStatusCode;
        }
    } 
}

 