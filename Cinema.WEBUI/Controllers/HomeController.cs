using Cinema.DAL.Context;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        SinFlexContext db = SinFlexContext.DBInstance;
        // GET: Home

        public ActionResult Login(string id)
        {
            if (id != null)
            {
                ViewBag.UyeOlmamissiniz = id;
            }
            return View();
            
        }
        [HttpPost]
        public ActionResult LoginUser(Member item)
        {
            if (db.Members.Any(x => x.UserName == item.UserName && x.Password == item.Password))
            {
                Member login = db.Members.FirstOrDefault(x => x.UserName == item.UserName && x.Password == item.Password);

                Session["Member"] = login;

                return RedirectToAction("Movie", "Movie");/*metot,controller*/
            }
            ViewBag.Mesaj = "Lütfen önce üye olun";
            return View();



        }
        public ActionResult SignUpUser(Member item)
        {
            if (db.Members.Any(x => x.UserName == item.UserName))
            {
                ViewBag.Mesaj = "This username is taken.";
               
            }
            return RedirectToAction("Home", "Home");
            
            
        }

        public ActionResult Movie()
        {
            return View(db.Movies.ToList());
        }



    }
}