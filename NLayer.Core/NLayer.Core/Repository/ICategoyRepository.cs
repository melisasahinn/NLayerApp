using NLayer.Core.Models;
using NLayer.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Repository
{
    public interface ICategoyRepository: IGenericRepository<Category>
    { 
        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
} 
