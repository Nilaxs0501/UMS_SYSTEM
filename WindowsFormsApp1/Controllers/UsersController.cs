using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    internal class UsersController
    {

        public static bool AddUser(Users user)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "INSERT INTO Users (Username, Password, Role, Name, Address) VALUES (@username, @password, @role, @name, @address)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.UserName);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@name", user.Name);
                        cmd.Parameters.AddWithValue("@address", user.Address);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
                return false;
            }
        }

        public static List<Users> GetAllUsers()
        {
            var users = new List<Users>();
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "SELECT UserID, Name, Address, Username, Role FROM Users";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new Users
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                UserName = reader["Username"].ToString(),
                                Role = reader["Role"].ToString(),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            return users;
        }

        public static bool UpdateUser(Users user)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "UPDATE Users SET Username=@username, Password=@password, Role=@role, Name=@name, Address=@address WHERE UserID=@userid";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.UserName);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@name", user.Name);
                        cmd.Parameters.AddWithValue("@address", user.Address);
                        cmd.Parameters.AddWithValue("@userid", user.UserID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteUser(int userId)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Users WHERE UserID=@userid";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userid", userId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
                return false;
            }


        }
        public static bool ChangePassword(string username, string currentPassword, string newPassword)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "UPDATE Users SET Password = @newPassword WHERE Username = @username AND Password = @currentPassword";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@currentPassword", currentPassword);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Change password: " + ex.Message);
                return false;
            }


        }



    }

}










