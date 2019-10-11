using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        QLDienDanEntities db = new QLDienDanEntities();
        // GET: Admin/Home
        public ActionResult Index()
        {
            if (Session["admin"] == null)
            {
                return Redirect("/Admin/Auth/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Add(NguoiDung user)
        {
            if(ModelState.IsValid)
            {
                db.NguoiDungs.Add(user);
                db.SaveChanges();
            }
            return View(user);
        }
    }
}