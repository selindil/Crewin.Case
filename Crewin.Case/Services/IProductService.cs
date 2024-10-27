using Crewin.Case.Entities;
using Crewin.Case.Models;

namespace Crewin.Case.Services
{
    public interface IProductService
    {


        #region apis 

        Task<ProductResponse> GetProductAsync(string name);
        #endregion
    }
}
