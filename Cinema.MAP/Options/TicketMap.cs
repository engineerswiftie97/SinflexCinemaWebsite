using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class TicketMap: BaseMap<Ticket>
    {
        public TicketMap()
        {
            ToTable("Tickets");
            Property(x => x.TicketAmount).HasColumnName("Ticket Amount").IsRequired();
            Property(x => x.TicketCount).HasColumnName("Ticket Count").IsRequired();
            Property(x => x.Price).HasColumnName("Ticket Price").IsRequired();
            Property(x => x.SoldTime).HasColumnName("Ticket's Sold Time").HasColumnType("datetime2");


        }
    }
}
