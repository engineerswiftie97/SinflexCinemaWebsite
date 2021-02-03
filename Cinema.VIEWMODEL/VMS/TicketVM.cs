using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMS
{
    public class TicketVM : BaseEntity
    {
        public double Price { get; set; }
        public DateTime SoldTime { get; set; }
        public int TicketAmount { get; set; }
    }
}
