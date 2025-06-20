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
    internal class ExamController
    {
        public static bool AddExam(Exam exam)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "INSERT INTO Exams (ExamName, SubjectID, ExamDate, ExamTime) VALUES (@name, @subjectId, @date, @time)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@date", exam.ExamDate);
                    cmd.Parameters.AddWithValue("@time", exam.ExamTime);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Exam> GetAllExams()
        {
            var list = new List<Exam>();
            using (var conn = DBconnection.GetConnection())
            {
                string query = @"SELECT e.ExamID, e.ExamName, e.SubjectID, e.ExamDate, e.ExamTime
                                 FROM Exams e
                                 JOIN Subjects s ON e.SubjectID = s.SubjectID";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Exam
                        {
                            ExamID = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            ExamDate = reader["ExamDate"].ToString(),
                            ExamTime = reader["ExamTime"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static bool UpdateExam(Exam exam)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "UPDATE Exams SET ExamName=@name, SubjectID=@subjectId, ExamDate=@date, ExamTime=@time WHERE ExamID=@id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@date", exam.ExamDate);
                    cmd.Parameters.AddWithValue("@time", exam.ExamTime);
                    cmd.Parameters.AddWithValue("@id", exam.ExamID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteExam(int examId)
        {
            using (var conn = DBconnection.GetConnection())
            {
                string query = "DELETE FROM Exams WHERE ExamID=@id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", examId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
