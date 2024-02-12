using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Razor_pages1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int qty { get; set; }
    }
}
