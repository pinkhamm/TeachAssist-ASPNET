﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachAssist.Models;

namespace TeachAssist.Controllers
{
    public class WidgetEditorController : Controller
    {
        Widget widget = new Widget(0, "New Widget", 0, 0);

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult SaveWidget()
        {
            ViewBag.Message = "Widget Saved!";
            return View();
        }

        public ActionResult DeleteWidget()
        {
            ViewBag.Message = "Widget Deleted.";
            return View();
        }
    }
}
