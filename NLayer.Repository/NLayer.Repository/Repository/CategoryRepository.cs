using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.Models;
using NLayer.Core.Repository;
using NLayer.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repository
{ 
    public class CategoryRepository : GenericRepository<Category>, ICategoyRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
          
        }
        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
