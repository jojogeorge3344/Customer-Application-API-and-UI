using CustomerApplication.Models;
using Microsoft.EntityFrameworkCore;
using CustomerApplication.ViewModel;

namespace CustomerApplication.Repository
{
    public class CustomerDetails :ICustomer
    {
        private readonly CustDBContext _customer;
        private CustDBContext _context;

        public CustomerDetails(CustDBContext context)
        {
            _context = context;
        }

        public async Task<int> CreateCustomer(Customer customer)
        {
            if (customer != null)
            {
                await _context.Customer.AddAsync(customer);
                await _context.SaveChangesAsync();
                return customer.id;
            }
            return 0;
        }


        public async Task<int> DeleteCustomer(int? id)
        {
            int affectedRows = 0;

            if (id != null)
            {
                var rec_id =  _context.Customer.FirstOrDefaultAsync(x => x.id == id).Result;
                if (rec_id != null)
                {
                    _context.Customer.Remove(rec_id);
                    affectedRows = await _context.SaveChangesAsync();
                }
                return affectedRows;

            }
            return affectedRows;
        }


        public async Task<int> UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                _context.Customer.Update(customer);
                await _context.SaveChangesAsync();
                return customer.id;
            }
            return 0;
        }

        public async Task<IEnumerable<Customer>> GetCustomer()
        {
            if (_context != null)
            {
                return await _context.Customer.ToListAsync();
            }

            return null;
        }

        public Customer GetCustomerById(int id)
        {

            if (_context != null)
            {
                return _context.Customer.FirstOrDefault(e => e.id == id);

            }
            return null;
        }

    }
}
