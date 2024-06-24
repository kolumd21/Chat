using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Dal.Interfaces
{
    public interface IGroupRepository<T>
    {
        Task<bool> Create(T entity);

        Task<T> Get(int id);

        IQueryable<T> GetAll();

        Task<bool> Delete(T entity);
    }
}
