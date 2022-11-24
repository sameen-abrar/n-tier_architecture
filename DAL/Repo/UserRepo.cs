using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<user, int, user>, IAuth
    {
        BloodDonateEntities1 db;
        internal UserRepo()
        {
            db = new BloodDonateEntities1();
        }
        public user Add(user obj)
        {
            db.users.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public user Authenticate(string username, string password)
        {
            var data = db.users.FirstOrDefault(u => u.uname.Equals(username) && u.password.Equals(password));
            if (data != null)
                return data;
            else
                return null;
        }

        public bool Delete(int id)
        {
            var db_obj = Get(id);
            db.users.Remove(db_obj);
            return db.SaveChanges() > 0;
        }

        public List<user> Get()
        {
            return db.users.ToList();
        }

        public user Get(int id)
        {
            return db.users.Find(id);
        }

        public bool update(user obj)
        {
            var db_obj = db.users.Find(obj.uname);
            db.Entry(db_obj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
