using EduSys.API.Filters;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using EduSys.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
    public class CategoryWithDtoController : CustomBaseController
    {
        private readonly IServiceWithDto<Category, CategoryDto> _categoryServiceWithDto;

        public CategoryWithDtoController(IServiceWithDto<Category, CategoryDto> categoryServiceDto)
        {
            _categoryServiceWithDto = categoryServiceDto;   
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            return CreateActionResult(await _categoryServiceWithDto.GetAllAsync());
        }
        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _categoryServiceWithDto.GetByIdAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto productDto)
        {
            return CreateActionResult(await _categoryServiceWithDto.AddAsync(productDto));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SaveAll(List<CategoryDto> productsDtos)
        {
            return CreateActionResult(await _categoryServiceWithDto.AddRangeAsync(productsDtos));
        }


        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto productDto)
        {
            return CreateActionResult(await _categoryServiceWithDto.UpdateAsync(productDto));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            return CreateActionResult(await _categoryServiceWithDto.RemoveAsync(id));
        }


        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveAll(List<int> ids)
        {

            return CreateActionResult(await _categoryServiceWithDto.RemoveRangeAsync(ids));
        }


        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Any(int id)
        {

            return CreateActionResult(await _categoryServiceWithDto.AnyAsync(x => x.Id == id));
        }

    
    }
}

