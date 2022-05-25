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
    [Authorize]

    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListServices _shopping;
        public ShoppingListController(IShoppingListServices shopping) => _shopping = shopping;
        [HttpGet]
        public async Task<IEnumerable<ShoppingList>> Get()
        {
            return await _shopping.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var list = await _shopping.GetShoppingListAsync(id);
            if (list.Count() < 0) return NotFound("Not found items at car");
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShoppingListDto value)
        {
            var response = await  _shopping.save(value);
            if (response == value) return Ok(response);
            return BadRequest(response);
        }
        [HttpPut("{id}")]
        public async Task<ShoppingListDto> Put(int id,[FromBody] ShoppingListDto value)
        {
            return _shopping.update(id, value);
        }

   
        [HttpDelete("{id}")]
        public Task<ShoppingList> Delete(int id)
        {
            return _shopping.delete(id);
        }
    }
}
