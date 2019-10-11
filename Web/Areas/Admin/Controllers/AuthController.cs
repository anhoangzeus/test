using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Areas.Admin.Models;
using System.Data.Sql;
using System.Data;

namespace Web.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        // GET: Admin/Auth
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(AdminWeb admin)
        {
            SqlConnection sqlConnection;
            string cn = "Data Source=DESKTOP-LKT5F30;Initial Catalog=QLDienDan;Integrated Security=True";
            sqlConnection = new SqlConnection(cn);
            sqlConnection.Open();

            string sql = "select * from Admins";
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                if (dataRow[0].ToString().Trim().Equals(admin.Username.Trim())
                    && dataRow[1].ToString().Trim().Equals(admin.Password.Trim()))
                {
                    Session.Add("admin", dataRow);
                    return Redirect("/Admin/Home/Index");
                }
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}