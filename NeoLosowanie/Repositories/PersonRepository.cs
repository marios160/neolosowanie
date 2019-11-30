using NeoLosowanie.Models;
using NeoLosowanie.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoLosowanie.Repositories
{
    class PersonRepository
    {

        internal static Person FindById(int id)
        {
            return DataBase.db.Table<Person>().Where(u => u.Id == id).FirstOrDefault();
        }

        internal static Person FindByEmail(string email)
        {
            email = email.Trim();
            return DataBase.db.Table<Person>().Where(u => u.Email == email).FirstOrDefault();
        }

        internal static List<Person> FindAllByIsMarriage(bool isMarriage)
        {
            return DataBase.db.Table<Person>().Where(u => u.CollectionId == SystemService.Collection.Id && u.IsMarriage == isMarriage).ToList();
        }

        internal static int Insert(Person person)
        {
            int result = DataBase.db.Update(person);
            if (result == 0)
                result = DataBase.db.Insert(person);
            return result;
        }

    }
}
