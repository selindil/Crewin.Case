using Crewin.Case.Entities;
using Crewin.Case.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;

namespace Crewin.Case.Services
{
    public class ProductService : IProductService
    {
        private readonly IEntityRepository<Product> _entityRepository;
        private readonly IEntityRepository<Category> _categoryRepository;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ProductService(IEntityRepository<Product> entityRepository, IEntityRepository<Category> categoryRepository, HttpClient httpClient, IConfiguration configuration)
        {
            _entityRepository = entityRepository;
            _categoryRepository = categoryRepository;
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.Timeout = TimeSpan.FromMinutes(6);
        }

        public async Task<bool> Create(Product product)
        {
            await _entityRepository.AddAsync(product);
            var result = await _entityRepository.SaveChangesAsync();
            return result;
        }

        public async Task<Product> GetById(int id)
        {
            var product = await _entityRepository.GetByIdAsync(id);
            if (product != null)
            {
                return product;

            }
            return new Product();
        }

        public async Task<List<Product>> GetCategoryById(int categoryId)
        {
            var products = await _entityRepository.FindAsync(x => x.CategoryId == categoryId);
            if (products != null)
            {
                return products.ToList();
            }
            return new List<Product>();
        }

        public async Task<List<Product>> GetList()
        {
            var products = await _entityRepository.GetAllAsync();
            return products.ToList();
        }
        
        public async  Task GetProductAsync()
        {
            //TODO Timeout veriyor bakılcak.
            var config = _configuration.GetValue<string>("ApiProduct");

            
            try
            {
                var responsee = await _httpClient.GetStringAsync(config);
                var response = await _httpClient.GetAsync(config);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var products = JsonSerializer.Deserialize<List<Product>>(json);
                    foreach (var item in products)
                    {
                        await _entityRepository.AddAsync(item);

                    }
                        await _entityRepository.SaveChangesAsync();

                }
            }
            catch (Exception ex )
            {

                throw;
            }
          
        }
    }
}
