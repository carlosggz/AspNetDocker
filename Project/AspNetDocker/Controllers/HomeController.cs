using AspNetDocker.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspNetDocker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new UserService().GetUsers());
        }

        public ActionResult Ping()
        {
            return Content("Ping");
        }
    }
}