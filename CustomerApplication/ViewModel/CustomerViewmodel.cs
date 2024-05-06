using CustomerApplication.Models;
using CustomerApplication.Repository;
using System.ComponentModel.DataAnnotations;

namespace CustomerApplication.ViewModel
{
    public class CustomerViewmodel
    {
        public Customer viewCustomer { get; set; }
        public int id { get; set; }
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Street1 { get; set; }
        public string City1 { get; set; }
        public string State1 { get; set; }
        public string Pincode1 { get; set; }
        public string Flag1 { get; set; }
        public string Address2 { get; set; }
        public string Street2 { get; set; }
        public string City2 { get; set; }
        public string State2 { get; set; }
        public string Pincode2 { get; set; }
        public string Flag2 { get; set; }
        public string Status { get; set; }

    }
}
