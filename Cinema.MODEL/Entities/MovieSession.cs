using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class MovieSession : BaseEntity
    {
        public Dates Date { get; set; }
        public Dates Special_Date { get; set; }
        public DateTime Time { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime FirstSessionTime { get; set; }


        public int? MovieID { get; set; }



        public MovieSession()
        {
            if (Date == Special_Date)
            {
                Ticket.Price = Ticket.Price * 0.5;

            }
            else if (Time == FirstSessionTime)
            {
                Ticket.Price = Ticket.Price * 0.5;
            }
        }
        //relational properties
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<MovieHallSession> MovieHallSessions { get; set; }
        public virtual List<Seat> Seats { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual List<Reservation> Reservations { get; set; }



    }
    public enum Dates
    {
       Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
   
}
