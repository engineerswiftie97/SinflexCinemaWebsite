using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class ReservationMap: BaseMap<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Reservations");

            //birebir ilişki icin 

            HasOptional(x => x.Seat).WithRequired(x => x.Reservation); //birebir ilişki tamamlandı.
            HasOptional(x => x.Ticket).WithRequired(x => x.Reservation);
        }
    }
}
