using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    internal class LoginController
    {
        public static Users GetUser(string username, string password, string role)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username = @u AND Password = @p AND Role = @r";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@r", role);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users
                            {
                                UserId = Convert.ToInt32(reader["UserID"]),
                                UserName = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

    }
}
