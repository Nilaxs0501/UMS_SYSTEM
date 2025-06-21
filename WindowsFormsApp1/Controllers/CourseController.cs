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
    internal class CourseController
    {
        
        
            public static List<Course> GetAllCourses()
            {
                var list = new List<Course>();
                using (var conn = DBconnection.GetConnection())
            {
                    string query = "SELECT * FROM Courses";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Course
                            {
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                CourseName = reader["CourseName"].ToString()
                            });
                        }
                    }
                }
                return list;
            }

            public static bool AddCourse(Course course)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "INSERT INTO Courses (CourseName) VALUES (@name)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", course.CourseName);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static bool UpdateCourse(Course course)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "UPDATE Courses SET CourseName = @name WHERE CourseID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", course.CourseName);
                        cmd.Parameters.AddWithValue("@id", course.CourseID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static bool DeleteCourse(int courseId)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Courses WHERE CourseID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", courseId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
        public static bool CourseExists(string courseName)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Courses WHERE CourseName = @name";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", courseName);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }


    }
}
