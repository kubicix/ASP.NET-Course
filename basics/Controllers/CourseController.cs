using basics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{

    // course
    public class CourseController : Controller
    {
        

    public IActionResult Details(int? id)
    {
        // id null ise list sayfasına yolla
        if(id == null)
        {
            return Redirect("/Course/List");
        }

        var course = Repository.GetById(id.Value); 

        //geçersiz id girilirse list sayfasına yolla
        if(course == null)
        {
            return Redirect("/Course/List"); // veya istediğiniz bir sayfaya yönlendirme yapabilirsiniz
        }

        return View(course);
    }

        // course/list
        public IActionResult List()
        {
            return View("CourseList",Repository.Courses);
        }
    }
}
