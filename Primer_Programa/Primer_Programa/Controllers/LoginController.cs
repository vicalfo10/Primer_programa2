using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primer_Programa.Models;


namespace Primer_Programa.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {

            Conexion con = new Conexion();

            Login obj = new Login();
            obj.usuario = "vgrana01";
            obj.contraseña = "123";
        
            return View(obj);
        }
    }
}