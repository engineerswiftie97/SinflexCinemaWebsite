using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMS
{
    public class MovieSessionVM : BaseEntity
    {
        public Dates Date { get; set; }
       
        public DateTime Time { get; set; }
       
    }
}
