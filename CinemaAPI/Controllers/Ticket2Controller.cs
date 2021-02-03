using Cinema.VIEWMODEL.VMRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaAPI.Controllers
{
    public class Ticket2Controller : Controller
    {
        // GET: Ticket

        TicketVMRepository trep = new TicketVMRepository();
        // GET: Movie
        public List<TicketVM> GetAllTickets()
        {
            return trep.SelectAll().Select(x => new TicketVM
            {
                ID = x.ID,
                Price = x.Price,
                TicketAmount = x.TicketAmount,
                SoldTime = x.SoldTime
            }).ToList();
        }
        [HttpPost]
        public List<TicketVM> AddTicket(TicketVM item)
        {

            trep.Add(item);
            trep.Save();
            return GetAllTickets();

        }

        [HttpDelete]
        public void RemoveTicket(int id)
        {
            trep.Delete(trep.GetByID(id));
            trep.Save();
        }

        public TicketVM GetTicketByID(int id)
        {
            return trep.GetByID(id);
        }

        [HttpPut]
        public void UpdateTickets(TicketVM item)
        {
            trep.Update(item);
        }

    }
}