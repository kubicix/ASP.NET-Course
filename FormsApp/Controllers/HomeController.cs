using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FormsApp.Controllers
{
	public class HomeController : Controller
	{
	

		public HomeController()
		{
			
		}

		public IActionResult Index(string searchString,string category)
		{
			var products = Repository.Products;

			if (!String.IsNullOrEmpty(searchString))
			{
				ViewBag.SearchString = searchString;
                searchString = searchString.ToLower(); // searchString değerini küçük harfe dönüştür
                products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
            }

			if (!String.IsNullOrEmpty(category) && category!="0")
			{
				products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
			}

			//ViewBag.Categories = new SelectList(Repository.Categories,"CategoryId","Name",category);
			var model = new ProductViewModel()
			{
				Products = products,
				Categories = Repository.Categories,
				SelectedCategory = category
			};

			return View(model);
			
		}

		public IActionResult Create()
		{
			ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
			return View();
		}

		//POST
		[HttpPost]
		public async Task<IActionResult> Create(Product model, IFormFile imageFile)
		{
			var allowedExtensions = new[]
			{
				".jpg",".jpeg",".png"
			};
			var extension = Path.GetExtension(imageFile.FileName);//abc.jpg   extension=jpg
			var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
			var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img",randomFileName);

			if (imageFile != null)
			{
				if(!allowedExtensions.Contains(extension))
				{
					ModelState.AddModelError("","Enter a valid Image.");
				}
			}

			if(ModelState.IsValid)
			{
				using (var stream = new FileStream(path, FileMode.Create))
				{
					await imageFile.CopyToAsync(stream);
				}
				model.Image = randomFileName;
				model.ProductId = Repository.Products.Count+1;
				Repository.CreateProduct(model);
				return RedirectToAction("Index");
			}
			ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
			return View(model);
			
		}

	}
}
