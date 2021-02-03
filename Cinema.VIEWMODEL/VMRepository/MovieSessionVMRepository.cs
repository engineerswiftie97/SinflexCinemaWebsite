using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public class MovieSessionVMRepository : BaseRepository<MovieSessionVM>
    {
        public override List<MovieSessionVM> SelectAll()
        {
            return db.MovieSessions.Select(x => new MovieSessionVM
            {
                ID = x.ID,
                Time = x.Time

            }).ToList();
        }
    }
}
