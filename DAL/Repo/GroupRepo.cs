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
        BloodDonateEntities1 db;
        internal GroupRepo()
        {
            db = new BloodDonateEntities1();
        }
        public group Add(group obj)
        {
            db.groups.Add(obj);
            db.SaveChanges();
            return obj;
        }
        public bool Delete(int id)
        {
            var db_obj = Get(id);
            db.groups.Remove(db_obj);
            return db.SaveChanges() > 0;
        }

        public List<group> Get()
        {
            return db.groups.ToList();
        }

        public group Get(int id)
        {
            return db.groups.Find(id);
        }

        public bool update(group obj)
        {
            var db_obj = Get(obj.id);
            db.Entry(db_obj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

    }
}
