using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        ReservationRepository rrep = new ReservationRepository();
      
        public List<Reservation> GetAllReservations()
        {
            return rrep.SelectAll().Select(x => new Reservation
            {
                ID = x.ID,
                ReservationDate = x.ReservationDate,
                ReservationName = x.ReservationName,
                ReservationCount = x.ReservationCount
            }).ToList();
        }
        [HttpPost]
        public List<Reservation> AddTicket(Reservation item)
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

        public Reservation GetReservationByID(int id)
        {
            return rrep.GetByID(id);
        }

        [HttpPut]
        public void UpdateReservations(Reservation item)
        {
            rrep.Update(item);
        }
    }
}