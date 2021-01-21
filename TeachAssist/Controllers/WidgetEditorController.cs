using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachAssist.Models;

namespace TeachAssist.Controllers
{
    public class WidgetEditorController : Controller
    {
        Widget widget = new Widget();
        public IActionResult Index()
        {
            return View();
        }

        public void SaveWidget()
        {

        }

        public void DeleteWidget()
        {

        }
    }
}
