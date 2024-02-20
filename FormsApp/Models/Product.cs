using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
	public class Product
	{
        [Display(Name="Product Id")]
        public int ProductId { get; set; }
        [Required]
		[Display(Name = "Product Name")]
		public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}

// 1 iphone 14 1
// 2 iphone 15 1