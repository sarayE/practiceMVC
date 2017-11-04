using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practiceMVCProj.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/path");
            }
            return Content("Hello from the ComicBooksController!");
        }
    }
}