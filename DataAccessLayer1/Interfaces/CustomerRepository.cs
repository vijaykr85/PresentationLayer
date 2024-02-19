using DataAccessLayer1.Data;
using DataAccessLayer1.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer1.Interfaces
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }
    }
}
