using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class MovieHall:BaseEntity
    {
        
        public string HallName { get; set; }


        public int? MovieID { get; set; }
        //relational properties

        public virtual Movie Movie { get; set; }
        public virtual List<MovieHallSession> MovieHallSessions { get; set; }


    }
}
