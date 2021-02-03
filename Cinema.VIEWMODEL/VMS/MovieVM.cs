using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMS
{
    public class MovieVM : BaseEntity
    {
        public string MovieName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Summary { get; set; }
    }
}
