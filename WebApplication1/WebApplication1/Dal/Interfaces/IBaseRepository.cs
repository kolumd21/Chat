using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Dal.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);

        Task<T> Get(long id);

        IQueryable<T> GetAll();

        Task<bool> Delete(T entity);
    }
}
