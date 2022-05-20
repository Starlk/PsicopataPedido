using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Domain.constantes;
using PsicopataPedido.Domain.Entities;
using PsicopataPedido.VIEW.Modal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PsicopataPedido.VIEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _user;
        private readonly IConfiguration _conf;

        public UserController(IUserServices user, IConfiguration conf)
        {
            _user = user;
            _conf = conf;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}"), Authorize]
        public Task<User> Get(int id)
        {
            return _user.getOne(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public UserDto Post([FromBody] UserDto value)
        {
    
           return _user.save(value);
            
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto value) 
        {
            var CredUser = new UserDto() { Email = value.Email, Password = value.Password };
            var result = _user.login(CredUser);
            if (result !=null) return Ok(_user.CreateToken(result, "Pato053434ffdfdssdfsdv"));
            return BadRequest("este usuario no existe");
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public  async Task<UserDto> Put(int id,[FromBody] UserDto value)
        {
           return _user.update(id,value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task<User> Delete(int id)
        {
            return _user.delete(id);
        }
    }
}
