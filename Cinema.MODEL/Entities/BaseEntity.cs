using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? DeletedDate { get; set; }


        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

    }

    public enum DataStatus
    {
        Inserted = 1, Updated = 2, Deleted = 3
    }
}

