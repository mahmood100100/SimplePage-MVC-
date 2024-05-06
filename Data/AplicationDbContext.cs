using Microsoft.EntityFrameworkCore;
using SimplePage.Models;

namespace SimplePage.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.;database = asp8;trusted_connection = true;TrustServerCertificate = true");
        }
    }
}
