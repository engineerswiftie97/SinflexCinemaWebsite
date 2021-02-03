using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMS
{
    public class ReservationVM : BaseEntity
    {
        public DateTime ReservationDate { get; set; }
        public int ReservationCount { get; set; }
        public string ReservationName { get; set; }
    }
}
