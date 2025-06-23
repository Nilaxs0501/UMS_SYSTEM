using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Controllers
{
    internal class TimeTableController
    {
        public static bool AddTimetable(Timetable t)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"INSERT INTO Timetables 
                    (SubjectID, TimeSlot, RoomID, GroupName, LecturerID) 
                    VALUES 
                    (@subjectId, @timeSlot, @roomId, @groupName, @lecturerId)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subjectId", t.SubjectID);
                        cmd.Parameters.AddWithValue("@timeSlot", t.TimeSlot);
                        cmd.Parameters.AddWithValue("@roomId", t.RoomID);
                        cmd.Parameters.AddWithValue("@groupName", t.GroupName);
                        cmd.Parameters.AddWithValue("@lecturerId", t.LecturerID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding timetable: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateTimetable(Timetable t)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"UPDATE Timetables SET 
                        SubjectID = @subjectId,
                        TimeSlot = @timeSlot,
                        RoomID = @roomId,
                        GroupName = @groupName,
                        LecturerID = @lecturerId
                        WHERE TimetableID = @timetableId";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subjectId", t.SubjectID);
                        cmd.Parameters.AddWithValue("@timeSlot", t.TimeSlot);
                        cmd.Parameters.AddWithValue("@roomId", t.RoomID);
                        cmd.Parameters.AddWithValue("@groupName", t.GroupName);
                        cmd.Parameters.AddWithValue("@lecturerId", t.LecturerID);
                        cmd.Parameters.AddWithValue("@timetableId", t.TimetableID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating timetable: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteTimetable(int timetableId)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Timetables WHERE TimetableID = @id";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", timetableId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting timetable: " + ex.Message);
                return false;
            }
        }

        public static List<dynamic> GetAllTimetables()
        {
            var list = new List<dynamic>();

            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"SELECT t.TimetableID, s.SubjectName, t.TimeSlot, 
                                            r.RoomName, t.GroupName, l.LecturerName
                                     FROM Timetables t
                                     JOIN Subjects s ON t.SubjectID = s.SubjectID
                                     JOIN Rooms r ON t.RoomID = r.RoomID
                                     JOIN Lecturers l ON t.LecturerID = l.LecturerID";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                TimetableID = Convert.ToInt32(reader["TimetableID"]),
                                SubjectName = reader["SubjectName"].ToString(),
                                TimeSlot = reader["TimeSlot"].ToString(),
                                RoomName = reader["RoomName"].ToString(),
                                GroupName = reader["GroupName"].ToString(),
                                LecturerName = reader["LecturerName"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading timetables: " + ex.Message);
            }

            return list;
        }
    }

    
}
