using lesson25.Data;
using lesson25.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25.Methods
{
    public  static class Method
    {

        public static void AddUser(User user)
        {
            using (var db = new UserDb())
            {
                db.Users.Add(user);

                db.SaveChanges();

            }

        }

        public static void RemoveUser(User user)
        {
            using (var db = new UserDb())
            {
                db.Users.Remove(user);

                db.SaveChanges();

            }

        }

        public static void UpdateUser(User user)
        {
            using (var db = new UserDb())
            {
                db.Users.Update(user);

                db.SaveChanges();

            }


        }

        public static void DeleteAll()
        {
            using (var db = new UserDb())
            {
                db.Users.ExecuteDelete();

                db.SaveChanges();

            }


        }

        public static void DeleteByName(string name)
        {
            using (var db = new UserDb())
            {
                var userl = db.Users.Where(p => p.Name == name);
                foreach (var user in userl)
                {
                    db.Users.Remove(user);
                }

                db.SaveChanges();

            }


        }

        public static void UpdateByName(string name, string name1)
        {
            using (var db = new UserDb())
            {
                var userl = db.Users.Where(p => p.Name == name);
                foreach (var user in userl)
                {
                    user.Name = name1;
                    db.Users.Update(user);
                }

                db.SaveChanges();

            }


        }



    }
}
