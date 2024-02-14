using Microsoft.EntityFrameworkCore;
using SimpleWebAPI.Models;

namespace SimpleWebAPI.Context
{
    public class SimpleDbContext : DbContext
    {
        public SimpleDbContext(DbContextOptions<SimpleDbContext>options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
