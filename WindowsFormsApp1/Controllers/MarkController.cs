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
    internal class MarkController
    {
        
    
        
        
            public static bool AddMark(Mark mark)
            {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@studentId, @examId, @score)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", mark.StudentID);
                    cmd.Parameters.AddWithValue("@examId", mark.ExamID);
                    cmd.Parameters.AddWithValue("@score", mark.Score);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            }

            public static List<Mark> GetAllMarks()
            {
                var list = new List<Mark>();
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"SELECT m.MarkID, m.StudentID,  m.ExamID, m.Score
                                 FROM Marks m
                                 JOIN Students s ON m.StudentID = s.StudentID
                                 JOIN Exams e ON m.ExamID = e.ExamID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Mark
                            {
                                MarkID = Convert.ToInt32(reader["MarkID"]),
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                ExamID = Convert.ToInt32(reader["ExamID"]),
                                Score = Convert.ToInt32(reader["Score"])
                            });
                        }
                    }
                }
                return list;
            }

            public static bool UpdateMark(Mark mark)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "UPDATE Marks SET StudentID=@studentId, ExamID=@examId, Score=@score WHERE MarkID=@id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", mark.StudentID);
                        cmd.Parameters.AddWithValue("@examId", mark.ExamID);
                        cmd.Parameters.AddWithValue("@score", mark.Score);
                        cmd.Parameters.AddWithValue("@id", mark.MarkID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static bool DeleteMark(int markId)
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Marks WHERE MarkID=@id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", markId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static List<Mark> GetMarksByStudent(int studentId)
            {
                var list = new List<Mark>();
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"SELECT m.MarkID, m.ExamID, m.Score
                                 FROM Marks m
                                 JOIN Exams e ON m.ExamID = e.ExamID
                                 WHERE m.StudentID = @studentId";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Mark
                                {
                                    MarkID = Convert.ToInt32(reader["MarkID"]),
                                    ExamID = Convert.ToInt32(reader["ExamID"]),
                                    Score = Convert.ToInt32(reader["Score"])
                                });
                            }
                        }
                    }
                }
                return list;
            }
        
    }

}

