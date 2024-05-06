using Microsoft.EntityFrameworkCore;
using CustomerApplication.Models;

namespace CustomerApplication.Repository
{
    public interface ICustomer
    {
        Task<int> CreateCustomer(Customer customer);
        Task<int> UpdateCustomer(Customer customer);
        Task<int> DeleteCustomer(int? id);
        Customer GetCustomerById(int id);
        Task<IEnumerable<Customer>> GetCustomer();


    }
}
