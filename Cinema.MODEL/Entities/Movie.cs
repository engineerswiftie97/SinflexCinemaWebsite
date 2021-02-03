using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class Movie:BaseEntity
    {
        public string MovieName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Summary { get; set; }
        

        //relational properties
        public virtual List<MovieHall> MovieHalls { get; set; }
        public virtual List<MovieSession> MovieSessions { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Reservation> Reservations { get; set; }


    }
}
