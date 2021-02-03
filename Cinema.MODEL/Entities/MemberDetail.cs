using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class MemberDetail:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string Phone { get; set; }


        public int? MemberID { get; set; }

        //relational properties
        public virtual Member Member { get; set; }
    }
}
