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

    public class ProductController : ControllerBase
    {
        private readonly IProductServices _product;

        public ProductController(IProductServices product) => _product = product;
        [HttpGet]
        [Authorize]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _product.GetAll();
        }

        [Authorize]
        [HttpGet("{id}")]
        public Task<Product> Get(int id)
        {
            return _product.getOne(id);
        }

        [Authorize(Roles = ApiRoles.admin)]
        [HttpPost]
        public async Task<ProductDto> Post([FromBody] ProductDto value)
        {
            return await _product.save(value);

        }

        [Authorize(Roles = ApiRoles.admin)]
        [HttpPut("{id}")]
        public async Task<ProductDto> Put(int id, [FromBody] ProductDto value)
        {
            return _product.update(id,value);
        }

        [Authorize(Roles = ApiRoles.admin)]
        [HttpDelete("{id}")]
        public Task<Product> Delete(int id)
        {
            return _product.delete(id);
        }
    }
}
