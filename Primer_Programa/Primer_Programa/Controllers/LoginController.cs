using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primer_Programa.Models;
using System.Data;


namespace Primer_Programa.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            Login obj = new Login();

            obj.usuario = "vgrana01";
            obj.contraseña = "123";

            return View(obj);
        }

        public ActionResult Valida_login()
        {
            Login obj = new Login();
            Conexion con = new Conexion();

            DataSet ds = new DataSet();

            string comando = "SELECT * FROM t_login";

            con.Llenar_Ds(ds, comando);

            if (ds.Tables[0].Rows.Count > 0)
            {

                obj.usuario = ds.Tables[0].Rows[0]["usuario"].ToString();
                obj.contraseña = ds.Tables[0].Rows[0]["clave"].ToString();
            }

            return View(obj);
        }
    }
}