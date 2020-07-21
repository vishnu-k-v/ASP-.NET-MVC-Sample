using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        userStore store;
      static  UserModel user = new UserModel();
        public HomeController()
        {
            store = new userStore();
            
        }
        public ActionResult Index()
        {
            user.Contact = null;
            user.Details = null;
            return View();
        }


        [HttpPost]
        public ActionResult Next(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                user.Contact = model;
                    return View("Next1");
            }

            return View("Index", model);
        }

        public ActionResult Next1()
        {
            return View();  
        }

        public ActionResult Succes(Account accmodel)
        {
           
            if (ModelState.IsValid)
            {
                user.Details = accmodel;
                store.Add(user);
                return View();
            }

            return View("Next1");
        }
    
    }
}