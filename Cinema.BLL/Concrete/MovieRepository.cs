using Cinema.BLL.BaseRepository;
using Cinema.DAL.Context;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL.Concrete
{
    public class MovieRepository : BaseRepository<Movie>
    {
        protected SinFlexContext db = SinFlexContext.DBInstance;

    }
}
