using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsApp.Controllers
{
	public class HomeController : Controller
	{
	

		public HomeController()
		{
			
		}

		public IActionResult Index(string searchString)
		{
			var products = Repository.Products;

			if (!String.IsNullOrEmpty(searchString))
			{
				ViewBag.SearchString = searchString;
				products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
			}
			return View(products);
			
		}

		public IActionResult Privacy()
		{
			return View();
		}

	}
}
