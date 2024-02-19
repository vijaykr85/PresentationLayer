using DataAccessLayer1.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options): base(options)

        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
