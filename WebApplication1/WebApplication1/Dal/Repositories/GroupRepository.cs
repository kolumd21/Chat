using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dal.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Dal.Repositories
{
    public class GroupRepository : IGroupRepository<Group>
    {
        private readonly AppDbContext _appDbContext;
        public GroupRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> Create(Group entity)
        {
            await _appDbContext.groups.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(Group entity)
        {
            _appDbContext.groups.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Group> Get(int id)
        {
            return await _appDbContext.groups.FirstOrDefaultAsync(x => x.id_group == id);
        }

        public IQueryable<Group> GetAll()
        {
            return _appDbContext.groups;
        }
    }
}
