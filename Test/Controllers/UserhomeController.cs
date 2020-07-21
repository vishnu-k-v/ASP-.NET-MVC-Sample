using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class UserhomeController : Controller
    {
        // GET: Userhome
        public ActionResult Index()
        {
            return View();
        }
    }
}