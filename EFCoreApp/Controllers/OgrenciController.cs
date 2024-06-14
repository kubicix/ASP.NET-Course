using EFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Controllers
{
	public class OgrenciController : Controller
	{
		private readonly DataContext _context;
        public OgrenciController(DataContext context)
        {
            _context = context;
        }

		public async Task<IActionResult> Index()
		{
			var ogrenciler = await _context.Ogrenciler.ToListAsync();
			return View(ogrenciler);
		}

        public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(Ogrenci model)
		{
			_context.Ogrenciler.Add(model);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}
