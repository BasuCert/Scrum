using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DailyScrumWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Users" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Users.svc or Users.svc.cs at the Solution Explorer and start debugging.
    public class Users : IUsers
    {
        Models.Model1 db = new Models.Model1();

        public bool Login(string Username, string Password)
        {
            var user = db.Users.Where(x => x.Username == Username).FirstOrDefault();

            if (user == null)
                return false;

            if (user.Password != new MyHash(Password).GetSha1())
                return false;

            return true;
        }

        public void ChangePass(string Username, string NewPassword)
        {
            var user = db.Users.Where(x => x.Username == Username).FirstOrDefault();
            db.Users.Attach(user);
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            user.Password = new MyHash(NewPassword).GetSha1();
            db.SaveChanges();
        }
    }
}
