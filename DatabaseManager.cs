using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnicomTICManagement_Project.Repositories
{
   
    
        public static class DatabaseManager
        {
            private static string dbFile = "unicomtic.db";
            private static string connectionString = $"Data Source={dbFile};Version=3;";

            public static void InitializeDatabase()
            {
                if (!File.Exists(dbFile))
                {
                    SQLiteConnection.CreateFile(dbFile);
                }

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    Data.CreateTables(connection);
                }
            }

            // ✅ This is the missing method
            public static SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }
        }
    
}

