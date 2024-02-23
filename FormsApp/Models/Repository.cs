namespace FormsApp.Models
{
	public class Repository
	{
		private static readonly List<Product> _products = new List<Product>();
		private static readonly List<Category> _categories = new List<Category>();

		static Repository()
		{
			_categories.Add
				(new Category()
				{
					CategoryId = 1,
					Name="Phone",
				}
				);
			_categories.Add
				(new Category()
				{
					CategoryId = 2,
					Name = "Laptop",
				}
				);
			_products.Add
				(new Product() 
				{
					ProductId = 1,
					Name="IPhone 13",
					Price = 60000,
					IsActive=true,
					Image="1.jpg",
					CategoryId=1
				}
				);
			_products.Add
				(new Product()
				{
					ProductId = 2,
					Name = "IPhone 14",
					Price = 70000,
					IsActive = false,
					Image = "2.jpg",
					CategoryId = 1
				}
				);
			_products.Add
				(new Product()
				{
					ProductId = 3,
					Name = "IPhone 15",
					Price = 80000,
					IsActive = true,
					Image = "3.jpg",
					CategoryId = 1
				}
				);
			_products.Add
				(new Product()
				{
					ProductId = 4,
					Name = "IPhone 16",
					Price = 90000,
					IsActive = false,
					Image = "4.jpg",
					CategoryId = 1
				}
				);
			_products.Add
				(new Product()
				{
					ProductId = 5,
					Name = "Macbook Air",
					Price = 80000,
					IsActive = false,
					Image = "5.jpg",
					CategoryId = 2
				}
				);
			_products.Add
				(new Product()
				{
					ProductId = 6,
					Name = "Macbook Pro",
					Price = 90000,
					IsActive = true,
					Image = "6.jpg",
					CategoryId = 2
				}
				);
		}

		public static List<Product> Products 
		{ 
			get 
			{ 
				return _products; 
			} 
		}

		public static void EditProduct(Product updatedProduct)
		{
			var entity=_products.FirstOrDefault(p=>p.ProductId==updatedProduct.ProductId);
			if(entity != null)
			{
				if (!string.IsNullOrEmpty(updatedProduct.Name))
				{
					entity.Name = updatedProduct.Name;
				}
				
				entity.Price = updatedProduct.Price;
				entity.Image = updatedProduct.Image;
				entity.IsActive = updatedProduct.IsActive;
				entity.CategoryId= updatedProduct.CategoryId;
			}
		}

		public static void EditIsActive(Product updatedProduct)
		{
			var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
			if (entity != null)
			{
				entity.IsActive = updatedProduct.IsActive;
			}
		}

		public static void DeleteProduct(Product entity)
		{
			var model = _products.FirstOrDefault(p => p.ProductId == entity.ProductId);
			if (model != null)
			{
				_products.Remove(model);
			}
		}

		public static List<Category> Categories
		{
			get
			{
				return _categories;
			}
		}

		public static void CreateProduct(Product model)
		{
			_products.Add(model);
		}


	}
}
