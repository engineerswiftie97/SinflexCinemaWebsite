using Cinema.BLL.BaseRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.VIEWMODEL.VMRepository
{
    public class MemberVMRepository:BaseRepository<MemberVM>
    {
        public override List<MemberVM> SelectAll()
        {
            return db.Members.Select(x => new MemberVM
            {
                ID = x.ID,
                Username = x.UserName,
                Password = x.Password
            }).ToList();
        }

    }
}
