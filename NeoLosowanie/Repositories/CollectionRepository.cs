using NeoLosowanie.Models;
using NeoLosowanie.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoLosowanie.Repositories
{
    class CollectionRepository
    {
        

        internal static List<Collection> FindAll()
        {
            return DataBase.db.Table<Collection>().Where(c => c.UserId == SystemService.User.Id).ToList();
        }

        internal static Collection FindById(int id)
        {
            return DataBase.db.Table<Collection>().Where(c => c.Id == id).FirstOrDefault();
        }

        internal static int Insert(Collection community)
        {
            int result = DataBase.db.Update(community);
            if (result == 0)
                result = DataBase.db.Insert(community);
            return result;
        }
    }

}

