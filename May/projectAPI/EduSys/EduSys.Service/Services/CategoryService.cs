using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;


        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<Core.DTOs.CustomResponseDto<Core.DTOs.CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync(int categroryId)
        {
            var category=await _categoryRepository.GetSingleCategoryWithProductsAsync(categroryId);
            var categoryDto = _mapper.Map<CategoryWithProductDto>(category);

            return CustomResponseDto<CategoryWithProductDto>.Success(200, categoryDto);
        }
    }
}
