using System.ComponentModel.DataAnnotations;

namespace CustomerApplication.Models
{
    public class Customer
    {

        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Address1")]
        public string Address1 { get; set; }

        [Required]
        [Display(Name = "Street1")]
        public string Street1 { get; set; }

        [Required]
        [Display(Name = "City1")]
        public string City1 { get; set; }

        [Required]
        [Display(Name = "State1")]
        public string State1 { get; set; }

        [Required]
        [Display(Name = "Pincode1")]
        public string Pincode1 { get; set; }

        [Required]
        [Display(Name = "Flag1")]
        public string Flag1 { get; set; }


        [Required]
        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "Street2")]
        public string Street2 { get; set; }

        [Required]
        [Display(Name = "City2")]
        public string City2 { get; set; }

        [Required]
        [Display(Name = "State2")]
        public string State2 { get; set; }

        [Required]
        [Display(Name = "Pincode2")]
        public string Pincode2 { get; set; }

        [Required]
        [Display(Name = "Flag2")]
        public string Flag2 { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }



    }
}
