using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cinema.MAP.options
{
    public class MemberMap: BaseMap<Member>
    {
        public MemberMap()
        {
            ToTable("Members");
            HasOptional(x => x.MemberDetail).WithRequired(x => x.Member);

        }

    }
}
