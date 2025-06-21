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
                string query = "INSERT INTO Exams (ExamName, SubjectID, ExamDate, ExamStartTime,ExamEndTime) VALUES (@name, @subjectId, @date, @StartTime,@EndTime)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@date", exam.ExamDate);
                    cmd.Parameters.AddWithValue("@time", exam.ExamStartTime);
                    cmd.Parameters.AddWithValue("@time", exam.ExamEndTime);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Exam> GetAllExams()
        {
            var list = new List<Exam>();
            using (var conn = DBconnection.GetConnection())
            {
                string query = "SELECT * FROM Exams";
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
                            ExamStartTime = reader["ExamStartTime"].ToString(),
                            ExamEndTime = reader["ExamEndTime"].ToString()
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
                string query = "UPDATE Exams SET ExamName=@name, SubjectID=@subjectId, ExamDate=@date, ExamStartTime=@StartTime ,ExamEndTime=@EndTime  WHERE ExamID=@id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@date", exam.ExamDate);
                    cmd.Parameters.AddWithValue("@StartTime", exam.ExamStartTime);
                    cmd.Parameters.AddWithValue("@EndTime", exam.ExamEndTime);
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
