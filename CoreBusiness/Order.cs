using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public string CustomerId { get; set; }
        public int OrderNumber { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ShipmentDate { get; set; }


        // navigation property for ef core
        public Customer Customer { get; set; }
    }
}
