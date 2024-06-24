using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dal.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Dal.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> Create(User entity)
        {
            await _appDbContext.users.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(User entity)
        {
            _appDbContext.users.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<User> Get(long id)
        {
            return await _appDbContext.users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> GetByLogin(string login)
        {
            return await _appDbContext.users.FirstOrDefaultAsync(x => x.Login == login);
        }

        public IQueryable<User> GetAll()
        {
            return _appDbContext.users;
        }
    }
}
