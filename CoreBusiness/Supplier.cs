using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TypeOfSupplies { get; set; }

        // navigation property for ef core
        public List<Product> Products { get; set; }
    }
}
