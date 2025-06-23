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
    internal class MarkController
    {


        public static bool AddMark(Mark mark)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("AddMark Error: " + ex.Message);
                return false;
            }
        }

        public static List<Mark> GetAllMarks()
        {
            var list = new List<Mark>();
            using (var conn = DBconnection.GetConnection())
            {
                string query = "SELECT * FROM Marks";
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

        public static List<Mark> GetMarksByStudent(int studentId)
        {
            var list = new List<Mark>();
            using (var conn = DBconnection.GetConnection())
            {
                string query = "SELECT * FROM Marks WHERE StudentID=@studentId";
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
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                ExamID = Convert.ToInt32(reader["ExamID"]),
                                Score = Convert.ToInt32(reader["Score"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        public static bool UpdateMark(Mark mark)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "UPDATE Marks SET StudentID=@studentId, ExamID=@examId, Score=@score WHERE MarkID=@markId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", mark.StudentID);
                    cmd.Parameters.AddWithValue("@examId", mark.ExamID);
                    cmd.Parameters.AddWithValue("@score", mark.Score);
                    cmd.Parameters.AddWithValue("@markId", mark.MarkID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteMark(int markId)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "DELETE FROM Marks WHERE MarkID=@markId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@markId", markId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


    }

}

