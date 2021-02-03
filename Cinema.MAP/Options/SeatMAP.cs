using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class SeatMap: BaseMap<Seat>
    {
        public SeatMap()
        {
            ToTable("Seats");
            
            

            //birebir ilişki icin 

            HasOptional(x => x.Ticket).WithRequired(x => x.Seat); //birebir ilişki tamamlandı.
        }
    }
}
