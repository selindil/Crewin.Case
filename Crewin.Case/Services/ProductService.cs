using Crewin.Case.Entities;
using Crewin.Case.Models;
using Crewin.Case.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;

namespace Crewin.Case.Services
{
    public class ProductService : IProductService
    {
        private readonly IEntityRepository<Category> _categoryRepository;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ProductService(IEntityRepository<Category> categoryRepository, HttpClient httpClient, IConfiguration configuration)
        {
            _categoryRepository = categoryRepository;
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri(configuration["ApiProduct"]);
        }


        public async Task<ProductResponse> GetProductAsync(string name)
        {
            try
            {
                var response = await _httpClient.GetAsync(name);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<ProductResponse>(json);

                    return products;
                }
                return new ProductResponse();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }//ProductService sınıfı, ürün bilgilerini almak için bir servis sağlar. Bu sınıf, API ile etkileşim kurarak ürün verilerini çeker ve ProductResponse nesnesi olarak döner. Kullanıcı, ürün adını vererek bu veriye ulaşabilir. Sınıf, modüler bir yapıya sahip olup, bağımlılıkları üzerinden yönetilir. Ayrıca, JSON verilerini işlemek için Newtonsoft.Json kütüphanesini kullanır.
}
