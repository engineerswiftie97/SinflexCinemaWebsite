using Cinema.VIEWMODEL.VMRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaAPI.Controllers
{
    public class Seat2Controller : Controller
    {
        SeatVMRepository mrep = new SeatVMRepository();
        // GET: Seat2
        public List<SeatVM> GetAllSeats()
        {
            return mrep.SelectAll().Select(x => new SeatVM
            {
                ID = x.ID,
                SeatNumber = x.SeatNumber

            }).ToList();
        }
    }
}