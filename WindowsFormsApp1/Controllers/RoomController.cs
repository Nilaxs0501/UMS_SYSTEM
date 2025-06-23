using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    internal class RoomController
    {
        public static List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "SELECT * FROM Rooms";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                RoomID = Convert.ToInt32(reader["RoomID"]),
                                RoomName = reader["RoomName"].ToString(),
                                RoomType = reader["RoomType"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }

            return rooms;
        }

        public static bool AddRoom(Room room)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", room.RoomName);
                        cmd.Parameters.AddWithValue("@type", room.RoomType);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateRoom(Room room)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "UPDATE Rooms SET RoomName=@name, RoomType=@type WHERE RoomID=@id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", room.RoomName);
                        cmd.Parameters.AddWithValue("@type", room.RoomType);
                        cmd.Parameters.AddWithValue("@id", room.RoomID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteRoom(int roomId)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Rooms WHERE RoomID=@id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", roomId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting room: " + ex.Message);
                return false;
            }
        }
    }
}
