using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Dal.Interfaces
{
    public interface IMessageRepository<T>
    {
        Task<bool> Create(T entity);

        Task<T> Get(int id);

        IQueryable<T> GetAll();

        Task<bool> Delete(T entity);
        Task<string> GetByUser(long id_user);


    }
}
