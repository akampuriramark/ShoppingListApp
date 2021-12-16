using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Grocery
    {
        // Name of the item
        // each grocery must have a name which is less than 15 characters
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters.")]
        public string Name { get; set; }

        // Price of the item
        [Required]
        // ensure the item has a price is in range (1-100000)
        [Range(1, 10000, ErrorMessage = " Valid Price range is (1-100000).")]
        public double Price { get; set; }
    }
}
