using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class MovieHallSession :BaseEntity
    {
        public int MovieHallID { get; set; }
        public int MovieSessionID { get; set; }
        //relational properties

        public virtual MovieSession MovieSession { get; set; }
        public virtual MovieHall MovieHall { get; set; }
    }
}
