using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<user, string, user>, IAuth
    {
        public bool Add(user obj)
        {
            throw new NotImplementedException();
        }

        public user Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<user> Get()
        {
            throw new NotImplementedException();
        }

        public user Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(user obj)
        {
            throw new NotImplementedException();
        }
    }
}
