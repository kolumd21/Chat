using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            Database.EnsureCreated();
        }
        public DbSet<User> users { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Message> messages { get; set; }

    }
}
