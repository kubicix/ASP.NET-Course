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
            var kurslar = new List<Course>(){
                new Course() {
                    Id =1,
                    Title="aspnet course",
                    Description="nice course"
                },
                new Course() {
                    Id =2,
                    Title="php",
                    Description="nice course"
                },
                new Course() {
                    Id =3,
                    Title="django course",
                    Description="nice course"
                },
                new Course() {
                    Id =4,
                    Title="Javascript course",
                    Description="nice course"
                }
            };
            return View("CourseList",kurslar);
        }
    }
}
