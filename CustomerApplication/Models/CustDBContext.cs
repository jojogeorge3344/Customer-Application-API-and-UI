using Microsoft.EntityFrameworkCore;

namespace CustomerApplication.Models
{
    public class CustDBContext : DbContext
    {
        public CustDBContext(DbContextOptions<CustDBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }

    }
}
