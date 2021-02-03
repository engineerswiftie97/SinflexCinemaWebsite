using Cinema.DAL.Context;
using Cinema.MODEL.Entities;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaAPI.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home
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
        public ActionResult LoginUser(MemberVM item)
        {
            if (db.Members.Any(x => x.UserName == item.Username && x.Password == item.Password))
            {
                Member login = db.Members.FirstOrDefault(x => x.UserName == item.Username && x.Password == item.Password);

                Session["Member"] = login;

                return RedirectToAction("Movie", "Movie");
            }
            ViewBag.Mesaj = "Lütfen önce üye olun";
            return View();



        }
        public ActionResult Movie()
        {
            return View(db.Movies.ToList());
        }

    }
}