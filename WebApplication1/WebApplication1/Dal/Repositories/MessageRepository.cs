using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dal.Interfaces;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Dal.Repositories
{
    public class MessageRepository : IMessageRepository<Message>
    {
        private readonly AppDbContext _appDbContext;
        public MessageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> Create(Message entity)
        {
            await _appDbContext.messages.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(Message entity)
        {
            _appDbContext.messages.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Message> Get(int id)
        {
            return await _appDbContext.messages.FirstOrDefaultAsync(x => x.id_message == id);
        }

        public async Task<string> GetByUser(long id_user)
        {
            var response = _appDbContext.users;

            var name = response.FirstOrDefault(x => x.Id == id_user);
            return name.Login;
        }

        public IQueryable<Message> GetAll()
        {
            return _appDbContext.messages;
        }
    }
}
