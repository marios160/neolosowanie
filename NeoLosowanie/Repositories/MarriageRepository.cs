using NeoLosowanie.Models;
using NeoLosowanie.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoLosowanie.Repositories
{
    class MarriageRepository
    {

        internal static Marriage FindById(int id)
        {
            Marriage marriage = DataBase.db.Table<Marriage>().Where(u => u.Person1Id == id || u.Person2Id == id).FirstOrDefault();
            marriage.Person1 = PersonRepository.FindById(marriage.Person1Id);
            marriage.Person2 = PersonRepository.FindById(marriage.Person2Id);
            return marriage;
        }

        internal static Marriage FindByPerson(Person person)
        {
            Marriage marriage = DataBase.db.Table<Marriage>().Where(u => u.Person1Id == person.Id || u.Person2Id == person.Id).FirstOrDefault();
            marriage.Person1 = PersonRepository.FindById(marriage.Person1Id);
            marriage.Person2 = PersonRepository.FindById(marriage.Person2Id);
            return marriage;
        }

        internal static bool Insert(Marriage marriage)
        {
            Marriage marr = DataBase.db.Table<Marriage>().Where(m =>
                m.Person1Id == marriage.Person1Id
                || m.Person1Id == marriage.Person2Id
                || m.Person2Id == marriage.Person1Id
                || m.Person2Id == marriage.Person2Id).FirstOrDefault();
            if(marr == null)
            {
                DataBase.db.Insert(marriage);
                return true;
            }
            return false;
        }

    }
}
