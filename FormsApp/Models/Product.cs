using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
	public class Product
	{
        [Display(Name="Product Id")]
        public int ProductId { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string Name { get; set; } = null!;
        [Required]
        [Range(0,200000)]
        public decimal Price { get; set; }
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}

// 1 iphone 14 1
// 2 iphone 15 1