using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class MovieHallMap:BaseMap<MovieHall>
    {
        public MovieHallMap()
        {
            ToTable("Movie Halls");
            Property(x => x.HallName).HasColumnName("Movie Hall Name").IsRequired();
        }
    }
}
