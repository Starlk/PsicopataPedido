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
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _product;

        public ProductController(IProductServices product) => _product = product;
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _product.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<Product> Get(int id)
        {
            return _product.getOne(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public ProductDto Post([FromBody] ProductDto value)
        {
            return _product.save(value);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ProductDto> Put(int id, [FromBody] ProductDto value)
        {
            return _product.update(id,value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task<Product> Delete(int id)
        {
            return _product.delete(id);
        }
    }
}
