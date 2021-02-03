using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using Cinema.WEBUI.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class TicketController : Controller
    {


        TicketRepository trep = new TicketRepository();
        // GET: TicketPrice
        public ActionResult VIP(Member item)
        {
            return View();
        }
        public ActionResult Student(Member item)
        {
            return View();
        }
        public ActionResult Normal(Member item)
        {
            return View();
        }




        // GET: Ticket
        public List<Ticket> GetAllTickets()
        {
            return trep.SelectAll().Select(x => new Ticket
            {
                ID = x.ID,
                Price = x.Price,
                TicketAmount = x.TicketAmount,
                SoldTime = x.SoldTime
            }).ToList();
        }
        [HttpPost]
        [EmployeeAuthentication]
        public List<Ticket> AddTicket(Ticket item)
        {

            trep.Add(item);
            trep.Save();
            return GetAllTickets();

        }

        [HttpDelete]
        [EmployeeAuthentication]
        public void RemoveTicket(int id)
        {
            trep.Delete(trep.GetByID(id));
            trep.Save();
        }
        [EmployeeAuthentication]
        public Ticket GetTicketByID(int id)
        {
            return trep.GetByID(id);
        }

        [HttpPut]
        [EmployeeAuthentication]
        public void UpdateTicket(Ticket item)
        {
            trep.Update(item);
        }
    }
}
