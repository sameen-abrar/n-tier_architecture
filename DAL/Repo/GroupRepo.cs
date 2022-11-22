using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class GroupRepo : IRepo<group, int, bool>
    {
        public bool Add(group obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<group> Get()
        {
            throw new NotImplementedException();
        }

        public group Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(group obj)
        {
            throw new NotImplementedException();
        }
    }
}
