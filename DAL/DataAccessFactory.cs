using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<group, int, bool> GroupDataAccess()
        {
            return new GroupRepo();
        }

        public static IRepo<donor, int, donor>DonorDataAccess()
        {
            return new DonorRepo();
        }
        public static IRepo<user, int, user> UserDataAccess()
        {
            return new UserRepo(); 
        }
        public static IAuth AuthDtataAccess()
        {
            return new UserRepo();
        }
    }
}
