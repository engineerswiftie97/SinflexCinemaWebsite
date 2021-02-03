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
    public class Member2Controller : Controller
    {
        // GET: Member
   
            SinFlexContext db = SinFlexContext.DBInstance;
            // GET: Member
            public ActionResult SelectUser(MemberVM item)
            {
                if (db.Members.Any(x => x.Roles == item.Roles && item.Roles == MemberRoles.VIP))
                {

                    return RedirectToAction("MovieVIP", "MovieVIP");

                }
                else if (db.Members.Any(x => x.Roles == item.Roles && item.Roles == MemberRoles.Student))
                {
                    return RedirectToAction("MovieStudent", "MovieStudent");
                }
                else if (db.Members.Any(x => x.Roles == item.Roles && item.Roles == MemberRoles.Owner))
                {
                    return RedirectToAction("OwnerPage", "OwnerPage");
                }
                else if (db.Members.Any(x => x.Roles == item.Roles && item.Roles == MemberRoles.BoxOffice))
                {
                    return RedirectToAction("BoxOfficePage", "BoxOfficePage");
                }
                else if (db.Members.Any(x => x.Roles == item.Roles && item.Roles == MemberRoles.Executive))
                {
                    return RedirectToAction("ExecutivePage", "ExecutivePage");
                }
                else if (db.Members.Any(x => x.Roles == item.Roles && item.Roles == MemberRoles.Normal))
                {
                    return RedirectToAction("MovieNormal", "MovieNormal");
                }
                return RedirectToAction("Movie", "Movie");
            }
        }
  
}