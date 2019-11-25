using NeoLosowanie.Models;
using NeoLosowanie.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoLosowanie.Repositories
{
    class UserRepository
    {
        internal static User FindByIsLogged(bool isLogged = true)
        {
            List<User> users = DataBase.db.Table<User>().Where(u => u.IsLogged == true).ToList();
            if(users.Count > 1)
            {
                foreach (var item in users)
                {
                    item.IsLogged = false;
                }
                DataBase.db.UpdateAll(users);
                return null;
            }
            return users.FirstOrDefault();
        }

        internal static User FindByEmail(string email)
        {
            email = email.Trim();
            return DataBase.db.Table<User>().Where(u => u.Email == email).FirstOrDefault();
        }

        internal static void LogInOut(User user)
        {
            List<User> users  = DataBase.db.Table<User>().Where(u => u.IsLogged == true).ToList();
            foreach (var item in users)
            {
                item.IsLogged = false;
            }
            DataBase.db.UpdateAll(users);
            DataBase.db.Update(user);
        }

        internal static int Insert(User user)
        {
            int result = DataBase.db.Update(user);
            if (result == 0)
                result = DataBase.db.Insert(user);
            return result;
        }
    }
}
