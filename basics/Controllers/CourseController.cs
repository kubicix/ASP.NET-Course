using basics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{

    // course
    public class CourseController : Controller
    {
        // course/index
        public IActionResult Index()
        {
            var course = new Course();
            course.Id=1;
            course.Title = "ASP.NET Core Course";
            course.Description = "Nice course for web development";
            return View(course);
        }
        // course/list
        public IActionResult List()
        {
            return View("CourseList");
        }
    }
}
