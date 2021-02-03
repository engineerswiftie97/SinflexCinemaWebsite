using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class MovieMap:BaseMap<Movie>
    {
        public MovieMap()
        {
            ToTable("Movies");
            Property(x => x.MovieName).HasColumnName("Movie Name").IsRequired();
            Property(x => x.ReleaseDate).HasColumnName("Movie Release Date").HasColumnType("datetime2");
            Property(x => x.Summary).HasColumnName("Movie Summary").IsRequired();
        }
        
    }
}
