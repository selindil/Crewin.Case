using Crewin.Case.Entities;

namespace Crewin.Case.Services
{
    public interface IProductService
    {
        Task<bool> Create(Product product);
        Task<List<Product>> GetList();
        Task<Product> GetById(int id);
        Task<List<Product>> GetCategoryById(int categoryId);

        #region apis 

        Task GetProductAsync();
        #endregion
    }
}
