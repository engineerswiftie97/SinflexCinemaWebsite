using Cinema.VIEWMODEL.VMRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaAPI.Controllers
{
    public class Reservation2Controller : Controller
    {
        // GET: Reservation
        ReservationVMRepository rrep = new ReservationVMRepository();
     
        public List<ReservationVM> GetAllReservations()
        {
            return rrep.SelectAll().Select(x => new ReservationVM
            {
                ID = x.ID,
                ReservationDate = x.ReservationDate,
                ReservationName = x.ReservationName,
                ReservationCount = x.ReservationCount
            }).ToList();
        }
        [HttpPost]
        public List<ReservationVM> AddTicket(ReservationVM item)
        {

            rrep.Add(item);
            rrep.Save();
            return GetAllReservations();

        }

        [HttpDelete]
        public void RemoveReservation(int id)
        {
            rrep.Delete(rrep.GetByID(id));
            rrep.Save();
        }

        public ReservationVM GetReservationByID(int id)
        {
            return rrep.GetByID(id);
        }

        [HttpPut]
        public void UpdateReservations(ReservationVM item)
        {
            rrep.Update(item);
        }
    }
}