using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {

        public BaseMap()
        {
            
                Property(x => x.CreatedDate).HasColumnName("Data Created Date").HasColumnType("datetime2");

                Property(x => x.ModifiedDate).HasColumnName("Data Modified Date").HasColumnType("datetime2");

                Property(x => x.Status).HasColumnName("Data Status");

            
        }
    }
}
