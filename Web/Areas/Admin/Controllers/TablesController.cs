using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.EF;

namespace Web.Areas.Admin.Controllers
{
    public class TablesController : Controller
    {
        DienDanDbContext db = null;
        public TablesController()
        {
            this.db = new DienDanDbContext();
        }
        // GET: Admin/Tables
        public ActionResult Index()
        {
            var result = this.db.NguoiDungs.ToList();
            return View(result);
        }

        
    }
}