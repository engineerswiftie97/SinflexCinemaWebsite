using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public class MovieVMRepository : BaseRepository<MovieVM>
    {
        public override List<MovieVM> SelectAll()
        {
            return db.Movies.Select(x => new MovieVM
            {
                ID = x.ID,
                MovieName = x.MovieName

            }).ToList();
        }
    }
}
