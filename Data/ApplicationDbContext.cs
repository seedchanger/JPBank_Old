using JPBank.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace JPBank.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<UserDbEntity> UsersDbSet { get; set; }
    }
}
