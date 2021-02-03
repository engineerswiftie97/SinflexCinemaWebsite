using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
   public class Ticket:BaseEntity
    {
        public int TicketAmount { get; set; }
        public double Price { get; set; }
        public DateTime SoldTime { get; set; }
        public int TicketCount { get; set; }

        public int? SeatID { get; set; }
        public int? MovieID { get; set; }
        public int? ReservationID { get; set; }
        public int? MemberID { get; set; }
        public int? MovieSessionID { get; set; }


        //relational properties
        public virtual  MovieSession MovieSession { get; set; }
        public virtual Member Member { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Reservation Reservation { get; set; }


    }
}
