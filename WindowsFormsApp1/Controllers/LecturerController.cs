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
    internal class LecturerController
    {
        public static bool AddLecturer(Lecturer lecturer)
        {
            try
            {
                using (var conn = DBconnection.GetConnection()) 
                {
                    string query = @"INSERT INTO Lecturers 
                        (LecturerName, SubjectID, Address, Email, PhoneNumber, Gender, Age) 
                        VALUES 
                        (@name, @subjectId, @address, @email, @phone, @gender, @age)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", lecturer.LecturerName);
                        cmd.Parameters.AddWithValue("@subjectId", lecturer.SubjectID);
                        cmd.Parameters.AddWithValue("@address", lecturer.Address);
                        cmd.Parameters.AddWithValue("@email", lecturer.Email);
                        cmd.Parameters.AddWithValue("@phone", lecturer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@gender", lecturer.Gender);
                        cmd.Parameters.AddWithValue("@age", lecturer.Age);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding lecturer: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateLecturer(Lecturer lecturer)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"UPDATE Lecturers SET 
                        LecturerName = @name, 
                        SubjectID = @subjectId, 
                        Address = @address,
                        Email = @email,
                        PhoneNumber = @phone,
                        Gender = @gender,
                        Age = @age 
                        WHERE LecturerID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", lecturer.LecturerName);
                        cmd.Parameters.AddWithValue("@subjectId", lecturer.SubjectID);
                        cmd.Parameters.AddWithValue("@address", lecturer.Address);
                        cmd.Parameters.AddWithValue("@email", lecturer.Email);
                        cmd.Parameters.AddWithValue("@phone", lecturer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@gender", lecturer.Gender);
                        cmd.Parameters.AddWithValue("@age", lecturer.Age);
                        cmd.Parameters.AddWithValue("@id", lecturer.LecturerID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating lecturer: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteLecturer(int lecturerId)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Lecturers WHERE LecturerID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", lecturerId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting lecturer: " + ex.Message);
                return false;
            }
        }

        public static List<Lecturer> GetAllLecturers()
        {
            var list = new List<Lecturer>();
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "SELECT * FROM Lecturers";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Lecturer
                            {
                                LecturerID = Convert.ToInt32(reader["LecturerID"]),
                                LecturerName = reader["LecturerName"].ToString(),
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                Address = reader["Address"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Age = Convert.ToInt32(reader["Age"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lecturers: " + ex.Message);
            }
            return list;
        }
    }
}
