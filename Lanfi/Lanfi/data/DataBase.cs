using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lanfi
{
    public class DataBase
    {
        private readonly SQLiteConnection conn;
        public DataBase(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<User>();
            conn.CreateTable<Connections>();
        }

        public List<User> GetUser()
        {
            return conn.Table<User>().ToList();
        }

        public List<Connections> GetConnections()
        {
            return conn.Table<Connections>().ToList();
        }

        public int SaveUser(User item)
        {
            return conn.Insert(item);
        }

        public int SaveConnections(Connections item)
        {
            return conn.Insert(item);
        }

        public void DeleteUser(User item)
        {
            conn.Delete(item);
        }
        public void DeleteConnections(Connections item)
        {
            conn.Delete(item);
        }
    }
}
