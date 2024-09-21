using JPBank.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace JPBank.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<UserDbEntity> Tbl_Users { get; set; }
    }
}
