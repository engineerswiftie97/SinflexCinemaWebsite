using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public class MovieHallVMRepository : BaseRepository<MovieHallVM>
    {
        public override List<MovieHallVM> SelectAll()
        {
            return db.MovieHalls.Select(x => new MovieHallVM
            {
                ID = x.ID,
                HallName = x.HallName
              
            }).ToList();
        }
       

    }





}
