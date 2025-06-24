using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagement_Project.Controllers
{
        public static class LoginController
        {
            
            private static string adminUsername = "admin";
            private static string adminPassword = "admin123";

            public static string LoggedInRole = "";

            public static bool Login(string username, string password, out string role)
            {
                role = "";

                
                if (username == adminUsername && password == adminPassword)
                {
                    role = "Admin";
                    return true;
                }


                using (var connection = Repositories.DatabaseManager.GetConnection())
                {
                    connection.Open();
                    var query = "SELECT Role FROM Users WHERE Username = @u AND Password = @p";
                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            role = result.ToString();
                            return true;
                        }
                    }
                }

                return false;
            }
        }
    }


