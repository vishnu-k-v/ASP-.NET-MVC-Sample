using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        userStore userStore = new userStore();
      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
               var s= userStore.Get(model.UserName, model.Password);
                if (s != null)
                {
                    return RedirectToAction("Index", "UserHome");

                }
                return View("Index");

            }
            return View("Index");
        }
    }
}