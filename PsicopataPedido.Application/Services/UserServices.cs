using AutoMapper;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Domain.constantes;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _user;
        protected readonly IMapper _mapper;

        public UserServices(IUserRepository user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }
        public Task<User> delete(int id)
        {
             return _user.DeleteById(id);
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _user.GetAll();
        }
        public Task<User> getOne(int id)
        {
            return _user.GetById(id);
        }

        public User login(UserDto user)
        {
            var isRegister = _mapper.Map<User>(user);
            return _user.Login(isRegister).Result;
        }
        public UserDto save(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _user.Save(user);
            return userDto;
        }
        public string CreateToken(User user,string value) 
        {
            List<Claim> clams = new List<Claim>
            {
                new Claim(ClaimTypes.Name, $"{user.Id}"),
                new Claim(ClaimTypes.Role, user.isAdmin ? ApiRoles.admin :ApiRoles.client)
         
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(value));
            var cred = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);
            var token =  new JwtSecurityToken(claims:clams,expires:DateTime.Now.AddDays(5), signingCredentials:cred);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public UserDto update(int id,UserDto entity)
        {
            var user = _mapper.Map<User>(entity);
            user.Id = id;
            _user.Update(user);
            return entity;
        }
    }
}
