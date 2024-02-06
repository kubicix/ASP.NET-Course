﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{

    // course
    public class CourseController : Controller
    {
        // course/index
        public string Index()
        {
            return "course/index";
        }
        // course/list
        public string List()
        {
            return "course/list";
        }
    }
}