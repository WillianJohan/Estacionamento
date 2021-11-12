using System.Collections.Generic;
using SQLite;

namespace Estacionamento_WPF.Database
{
    public static class SQLiteBaseOperations
    {

        static SQLiteConnectionString ConnectionString = new SQLiteConnectionString(SQLiteConfiguration.DatabaseCompletePath, true, key: "Est@c10nAM#nto");

        public static bool Insert<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.CreateTable<T>();
                int tableRows = connection.Insert(item);
                result = tableRows > 0;
            }

            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.CreateTable<T>();
                int tableRows = connection.Update(item);
                result = tableRows > 0;
            }

            return result;
        }

        public static bool Remove<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.CreateTable<T>();
                int tableRows = connection.Delete(item);
                result = tableRows > 0;
            }

            return result;
        }

        public static List<T> Read<T>() where T : new()
        {
            List<T> items = new List<T>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.CreateTable<T>();
                items = connection.Table<T>().ToList();
            }

            return items;
        }

    }
}
