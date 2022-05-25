using AutoMapper;
using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Services
{
    public class CategoryServices : ICategoryServices
    {
        ICategoryRepository _category;
        IMapper _mapper;
        public CategoryServices(ICategoryRepository category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }
        public Task<Category> delete(int id)
        {
            
            return _category.DeleteById(id);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categoryList = await _category.GetAll();

            return categoryList;
        }

        public Task<Category> getOne(int id)
        {
            return _category.GetById(id);
        }

        public async Task<CategoryDto> save(CategoryDto entity)
        {
            var category = _mapper.Map<Category>(entity);
            await _category.Save(category);
            return entity;
        }

        public CategoryDto update(int id, CategoryDto entity)
        {
            var category = _mapper.Map<Category>(entity);
            _category.Update(category);
            return entity;
        }
    }
}
