using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class MovieHallSessionMap: BaseMap<MovieHallSession>
    {
        public MovieHallSessionMap()
        {
            ToTable("Movie Hall Sessions");
            Ignore(x => x.ID); 

            HasKey(x => new
            {
                x.MovieHallID,
                x.MovieSessionID
            }); //CompositeKey

        }

    }
}
