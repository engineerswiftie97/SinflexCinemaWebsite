using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class Seat:BaseEntity
    {
        public string SeatNumber { get; set; }
        public int SeatCount = 50;


        public int? MovieSessionID { get; set; }
        public int? TicketID { get; set; }
        public int? ReservationID { get; set; }


        //relational properties

        public virtual MovieSession MovieSession { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual Reservation Reservation { get; set; }


    }
}
