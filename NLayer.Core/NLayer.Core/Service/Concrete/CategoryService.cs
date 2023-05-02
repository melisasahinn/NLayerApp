using NLayer.Core.DTO;
using NLayer.Core.Models;
using NLayer.Core.Repository;
using NLayer.Core.Service;
using NLayer.Core.UnitOfWork;
using NLayer.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Service
{
    public class CategoryService : Service<Category>,ICategoryService
    {
        private readonly ICategoyRepository _categoyRepository;

        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ICategoyRepository categoyRepository) : base(repository, unitOfWork)
        {
            _categoyRepository = categoyRepository;
        }

        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
