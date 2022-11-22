using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DonorRepo : IRepo<donor, int, donor>
    {
        public bool Add(donor obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<donor> Get()
        {
            throw new NotImplementedException();
        }

        public donor Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(donor obj)
        {
            throw new NotImplementedException();
        }
    }
}
