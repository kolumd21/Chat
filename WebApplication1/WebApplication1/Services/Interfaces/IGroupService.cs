using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models.Response;
using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces
{
    public interface IGroupService
    {
        Task<IBaseResponse<Group>> Create(string name);
        Task<IBaseResponse<IEnumerable<Group>>> GetAll();
    }
}
