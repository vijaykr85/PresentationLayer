using DataAccessLayer1.Entities;

namespace BusinessLogicLayer
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();

        //Task<Customer> GetCustomerByIdAsync(int id);

        //Task<Customer> AddCustomersAsync(Customer customer);
        //Task UpdateCustomerAsync(Customer customer);
        //Task DeleteCustomerAsync(int id);
    }
}
