using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Response;

namespace WebApplication1.Services.Interfaces
{
    public interface IMessageService
    {
        Task<IBaseResponse<Message>> Create(string message,string login,int id_group);
        Task<IBaseResponse<IEnumerable<MessageModelView>>> GetAll();
    }
}
