using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public class ReservationVMRepository : BaseRepository<ReservationVM>
    {
        public override List<ReservationVM> SelectAll()
        {
            return db.Reservations.Select(x => new ReservationVM
            {
                ID = x.ID,
                ReservationName = x.ReservationName

            }).ToList();
        }
    }
}
