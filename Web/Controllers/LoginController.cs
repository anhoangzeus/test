using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Log in
        [HttpGet]
        public ActionResult Index( )
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
                ViewBag.success = "You are login success";
            }
            return View();
        }

    }
}