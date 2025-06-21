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
    internal class SubjectController
    {
       
        
            public static List<Subject> GetAllSubjects()
            {
                var list = new List<Subject>();
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "SELECT * FROM Subjects";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Subject
                            {
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                SubjectName = reader["SubjectName"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"])
                            });
                        }
                    }
                }
                return list;
            }

            public static bool AddSubject(Subject subject)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @courseId)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                        cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static bool UpdateSubject(Subject subject)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "UPDATE Subjects SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                        cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                        cmd.Parameters.AddWithValue("@id", subject.SubjectID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static bool DeleteSubject(int subjectId)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Subjects WHERE SubjectID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", subjectId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

        public static bool SubjectExists(string subjectName, int courseId)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Subjects WHERE SubjectName = @name AND CourseID = @courseId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", subjectName);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

    }
}
