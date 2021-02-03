using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public class TicketVMRepository : BaseRepository<TicketVM>
    {
        public override List<TicketVM> SelectAll()
        {
            return db.Tickets.Select(x => new TicketVM
            {
                ID = x.ID,
                Price = x.Price

            }).ToList();
        }
    }
}
