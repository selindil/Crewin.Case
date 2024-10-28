using Crewin.Case.Entities;
using Crewin.Case.Repositories.Interface;
using System.Net.Http;
using System.Text.Json;

namespace Crewin.Case.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IEntityRepository<Category> _categoryRepository;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public CategoryService(IEntityRepository<Category> categoryRepository, HttpClient httpClient, IConfiguration configuration)
        {
            _categoryRepository = categoryRepository;
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri(configuration["ApiCategory"]);

        }

        public async Task<bool> Create(Category category)
        {
            await _categoryRepository.AddAsync(category);
            var result = await _categoryRepository.SaveChangesAsync();
            return result;

        }

        public async Task<Category> GetById(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category != null)
            {
                return category;

            }
            return new Category();
        }

        public async Task GetCategoriesAsync()
        {
            var response = await _httpClient.GetAsync("");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var categories = JsonSerializer.Deserialize<List<Category>>(json);
                foreach (var item in categories)
                {
                    await _categoryRepository.AddAsync(item);

                }
                await _categoryRepository.SaveChangesAsync();

            } //public async Task GetCategoriesAsync(): API'den tüm kategorileri çeker. Başarılı bir yanıt alındığında, JSON verisi Category nesnelerine dönüştürülür ve repository'e eklenir.
;
        }

        public async Task<List<Category>> GetList()
        {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories != null) return categories.ToList();
            return new List<Category>();
        }
    }
}
//CategoryService sınıfı, kategori ile ilgili CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren bir servis sağlar. HTTP istekleri yaparak dış bir API ile etkileşim kurar ve verileri bir repository aracılığıyla saklar. Bu yapı, uygulamanın modüler ve test edilebilir olmasını sağlar.