using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Domain.constantes;
using PsicopataPedido.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PsicopataPedido.VIEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = ApiRoles.admin)]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryServices _category;
        public CategoryController(ICategoryServices category)=>_category=category;

        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _category.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<Category> Get(int id)
        {
            return _category.getOne(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public CategoryDto Post([FromBody] CategoryDto value)
        {
            return _category.save(value);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<CategoryDto> Put(int id, [FromBody] CategoryDto value)
        {
            Console.WriteLine(id);
            return _category.update(id,value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task<Category> Delete(int id)
        {
            return _category.delete(id);
        }

    }
}
