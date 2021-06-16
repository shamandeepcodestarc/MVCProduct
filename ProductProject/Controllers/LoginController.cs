
using ProductProject
using ProductProject.ProModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductProject.Controllers
{
    public class LoginController : Controller
    {
        ProductDBEntities db = new ProductDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(regitser model)
        {
            user data = new user();
            model.Id = Guid.NewGuid();
            model.username = data.username;
            model.fullname = data.fullname;
            model.age = data.age;
            model.password = data.password;
            model.email = data.email;
            model.phone = data.phone;
            model.isactive = data.isdelete ;
            model.isdelete = data.isdelete;
            db.users.Add(model);
            return View();
        }

      
    }
}