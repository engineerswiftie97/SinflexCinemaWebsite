using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class Reservation:BaseEntity
    {
        public DateTime ReservationDate { get; set; }
        public int ReservationCount{ get; set; }
        public string ReservationName { get; set; }

        public int? TicketID { get; set; }
        public int? SeatID { get; set; }
        public int? MovieSessionID { get; set; }
        public int? MemberID { get; set; }
        public int? MovieID { get; set; }





        //relational properties
        public virtual Ticket Ticket { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual MovieSession MovieSession { get; set; }
        public virtual Member Member { get; set; }
        public virtual Movie Movie { get; set; }



    }
}
