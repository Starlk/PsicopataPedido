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

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Task<ShoppingList> Get(int id)
        {
            return _shopping.getOne(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public ShoppingListDto Post([FromBody] ShoppingListDto value)
        {
            return _shopping.save(value);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ShoppingListDto> Put([FromBody] ShoppingListDto value)
        {
            return _shopping.update(value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task<ShoppingList> Delete(int id)
        {
            return _shopping.delete(id);
        }
    }
}
