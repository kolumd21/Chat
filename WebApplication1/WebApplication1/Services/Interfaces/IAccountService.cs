using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models.Response;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;
using System.Security.Claims;

namespace WebApplication1.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IBaseResponse<ClaimsIdentity>> Login(LoginViewModel model);
        Task<IBaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

    }
}
