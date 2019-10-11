using Register.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Register.Controllers
{
    public class RegisterController : Controller
    {
        Web_ForumEntitiess db = new Web_ForumEntitiess();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SaveData(Siteuser model)
        {
            db.Siteusers.Add(model);
            db.SaveChanges();
            return Json("success", JsonRequestBehavior.AllowGet);
        }
    }
}