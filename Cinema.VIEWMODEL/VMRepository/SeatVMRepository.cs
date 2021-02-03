using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public  class SeatVMRepository : BaseRepository<SeatVM>
    {
        public override List<SeatVM> SelectAll()
        {
            return db.Seats.Select(x => new SeatVM
            {
                ID = x.ID,
                SeatNumber = x.SeatNumber

            }).ToList();
        }
    }
}
