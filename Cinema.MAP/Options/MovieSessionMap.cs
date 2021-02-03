using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class MovieSessionMap: BaseMap<MovieSession>
    {
        public MovieSessionMap()
        {
            Property(x => x.Date).HasColumnName("Movie Session Date").IsRequired();
            Property(x => x.Special_Date).HasColumnName("Movie Session Special Date").IsRequired();
            Property(x => x.Time).HasColumnName("Movie Session").HasColumnType("datetime2");
            Property(x => x.FirstSessionTime).HasColumnName("Movie's First Session").HasColumnType("datetime2");

        }
    }
}
