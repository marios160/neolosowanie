using NeoLosowanie.Models;
using SQLite;
using System;
using System.IO;

namespace NeoLosowanie.Services
{
    class DataBase
    {
        public static string DbPath { get; set; } = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.Personal),
        "neolosowanie.db3");
        public static SQLiteConnection db { get; set; }
        public DataBase()
        {
            db = new SQLiteConnection(DbPath);
            db.DropTable<User>();
            db.DropTable<Collection>();
            db.DropTable<Person>();
            db.CreateTable<User>();
            db.CreateTable<Collection>();
            db.CreateTable<Person>();
        }
    }
}
