using CarAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Services
{
    public class MssqlDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }

        public MssqlDbContext(DbContextOptions<MssqlDbContext> options) : base(options)
        {

        }
    }
}
