using System;
using System.IO;

namespace Estacionamento_WPF.Database
{
    public static class SQLiteConfiguration
    {
        public static string FolderPath = Environment.CurrentDirectory;
        public static string DatabaseName = "MyDatabase.db3";
        public static string DatabaseCompletePath = Path.Combine(FolderPath, DatabaseName);
    }
}
