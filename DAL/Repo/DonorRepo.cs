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
        BloodDonateEntities1 db;
        internal DonorRepo()
        {
            db = new BloodDonateEntities1();
        }
        public donor Add(donor obj)
        {
            db.donors.Add(obj);
            db.SaveChanges();
            return obj;
        }
        public bool Delete(int id)
        {
            var db_obj = Get(id);
            db.donors.Remove(db_obj);
            return db.SaveChanges() > 0;
        }

        public List<donor> Get()
        {
            return db.donors.ToList();
        }

        public donor Get(int id)
        {
            return db.donors.Find(id);
        }

        public bool update(donor obj)
        {
            var db_obj = Get(obj.id);
            db.Entry(db_obj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
