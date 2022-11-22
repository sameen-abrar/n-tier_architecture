using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class groupService
    {
        public static void getGroup()
        {
           var data = DataAccessFactory.GroupDataAccess().Get();
        }
    }
}
