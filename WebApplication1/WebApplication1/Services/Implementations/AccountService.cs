using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using System.Threading.Tasks;
using WebApplication1.Dal.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;
using WebApplication1.Services.Interfaces;
using WebApplication1.Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Response;
using WebApplication1.Models.Enum;
using WebApplication1.Models.Helper;
using System.Security.Claims;
using System.Collections.Generic;

namespace WebApplication1.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IBaseRepository<User> _userRepository;
        public AccountService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IBaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Email == model.Email);
                if(user == null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользыватель не найден"

                    };
                }
                if(user.Password != HashPassword.HashPasswordCreate(model.Password))
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Неверый пароль или логин",
                    };
                }
                var result = Authenticate(user);
                return new BaseResponse<ClaimsIdentity>()
                {
                    Data = result,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<ClaimsIdentity>> Register(RegisterViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Email == model.Email);
                if(user != null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Такой пользыватель уже есть"
                    };
                }
                user = new User()
                {
                    Email = model.Email,
                    Login = model.Login,
                    Password = HashPassword.HashPasswordCreate(model.Password),
                };
                await _userRepository.Create(user);
                var result = Authenticate(user);
                return new BaseResponse<ClaimsIdentity>()
                {
                    Data = result,
                    Description = "Объект создан",
                    StatusCode = StatusCode.OK
                };
            }
            catch(Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        private ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType,user.Email),
            };
            return new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
