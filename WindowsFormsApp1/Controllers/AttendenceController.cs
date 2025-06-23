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
    internal class AttendenceController
    {
 
    
        public class AttendanceController
        {
            public static bool AddAttendance(Attendance att)
            {
                try
                {
                    using (var conn = DBconnection.GetConnection())
                    {
                        string query = @"INSERT INTO Attendance 
                        (StudentID, SubjectID, Date, Status) 
                        VALUES (@studentId, @subjectId, @date, @status)";

                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@studentId", att.StudentID);
                            cmd.Parameters.AddWithValue("@subjectId", att.SubjectID);
                            cmd.Parameters.AddWithValue("@date", att.Date);
                            cmd.Parameters.AddWithValue("@status", att.Status);

                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding attendance: " + ex.Message);
                    return false;
                }
            }

            public static bool UpdateAttendance(Attendance att)
            {
                try
                {
                    using (var conn = DBconnection.GetConnection())
                    {
                        string query = @"UPDATE Attendance SET 
                        Status = @status
                        WHERE AttendanceID = @id";

                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", att.Status);
                            cmd.Parameters.AddWithValue("@id", att.AttendanceID);

                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating attendance: " + ex.Message);
                    return false;
                }
            }

            public static bool DeleteAttendance(int attendanceId)
            {
                try
                {
                    using (var conn = DBconnection.GetConnection())
                    {
                        string query = "DELETE FROM Attendance WHERE AttendanceID = @id";

                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", attendanceId);
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting attendance: " + ex.Message);
                    return false;
                }
            }

            public static List<dynamic> GetAttendanceBySubjectAndDate(int subjectId, string date)
            {
                var list = new List<dynamic>();
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"SELECT a.AttendanceID, s.StudentID, s.StudentName, a.Status
                                 FROM Students s
                                 LEFT JOIN Attendance a 
                                 ON a.StudentID = s.StudentID AND a.SubjectID = @subjectId AND a.Date = @date";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.Parameters.AddWithValue("@date", date);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new
                                {
                                    AttendanceID = reader["AttendanceID"] != DBNull.Value ? Convert.ToInt32(reader["AttendanceID"]) : -1,
                                    StudentID = Convert.ToInt32(reader["StudentID"]),
                                    StudentName = reader["StudentName"].ToString(),
                                    Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "Absent"
                                });
                            }
                        }
                    }
                }
                return list;
            }

            public static List<dynamic> GetStudentAttendance(int studentId)
            {
                var list = new List<dynamic>();
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"SELECT a.Date, subj.SubjectName, a.Status
                                 FROM Attendance a
                                 JOIN Subjects subj ON a.SubjectID = subj.SubjectID
                                 WHERE a.StudentID = @studentId";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new
                                {
                                    Date = reader["Date"].ToString(),
                                    SubjectName = reader["SubjectName"].ToString(),
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
                return list;
            }
        }
        public static List<dynamic> GetAttendanceByStudent(int studentId)
        {
            var list = new List<dynamic>();

            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"SELECT a.Date, s.SubjectName, a.Status
                             FROM Attendance a
                             JOIN Subjects s ON a.SubjectID = s.SubjectID
                             WHERE a.StudentID = @studentId
                             ORDER BY a.Date DESC";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new
                                {
                                    Date = Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd"),
                                    SubjectName = reader["SubjectName"].ToString(),
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching attendance: " + ex.Message);
            }

            return list;
        }


    }

}

