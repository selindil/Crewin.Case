using Crewin.Case.Entities;

namespace Crewin.Case.Services
{
    public interface ICategoryService
    {
        Task<bool> Create(Category category);
        Task<List<Category>> GetList();
        Task<Category> GetById(int id);


        #region apis 

        Task GetCategoriesAsync();
        #endregion
    }
}
