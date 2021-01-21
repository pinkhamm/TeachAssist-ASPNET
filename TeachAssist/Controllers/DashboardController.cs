using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachAssist.Models;

namespace TeachAssist.Controllers
{
    public class DashboardController : Controller
    {
        Classroom classroom = new Classroom();
        public IActionResult Index()
        {

            classroom.LoadClassroom(0);
            return View();
        }

        /*
        public IActionResult Index(int classroomNum)
        {
            classroom.LoadClassroom(classroomNum);
            return View();
        }
        */
    }
}
