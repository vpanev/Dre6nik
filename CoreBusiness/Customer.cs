using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CoreBusiness
{
    public class Customer : IdentityUser
    {
        public string CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }


        // navigation property for ef core
        public List<Order> Orders { get; set; }
    }
}
