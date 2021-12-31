using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public char Size { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
        [Required]
        public string PictureUrl { get; set; }

        // navigation property for ef core
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }
}
