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
    internal class StudentController
    {
        // Add Student
        public static bool AddStudent(Student student)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"INSERT INTO Students 
                        (StudentName, Address, Email, PhoneNumber, Gender, GroupName, Age, CourseID)
                        VALUES (@name, @address, @email, @phone, @gender, @group, @age, @courseId)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", student.StudentName);
                        cmd.Parameters.AddWithValue("@address", student.Address);
                        cmd.Parameters.AddWithValue("@email", student.Email);
                        cmd.Parameters.AddWithValue("@phone", student.PhoneNumber);
                        cmd.Parameters.AddWithValue("@gender", student.Gender);
                        cmd.Parameters.AddWithValue("@group", student.GroupName);
                        cmd.Parameters.AddWithValue("@age", student.Age);
                        cmd.Parameters.AddWithValue("@courseId", student.CourseID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
                return false;
            }
        }

        // Update Student
        public static bool UpdateStudent(Student student)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = @"UPDATE Students SET 
                        StudentName = @name,
                        Address = @address,
                        Email = @email,
                        PhoneNumber = @phone,
                        Gender = @gender,
                        GroupName = @group,
                        Age = @age,
                        CourseID = @courseId
                        WHERE StudentID = @id";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", student.StudentName);
                        cmd.Parameters.AddWithValue("@address", student.Address);
                        cmd.Parameters.AddWithValue("@email", student.Email);
                        cmd.Parameters.AddWithValue("@phone", student.PhoneNumber);
                        cmd.Parameters.AddWithValue("@gender", student.Gender);
                        cmd.Parameters.AddWithValue("@group", student.GroupName);
                        cmd.Parameters.AddWithValue("@age", student.Age);
                        cmd.Parameters.AddWithValue("@courseId", student.CourseID);
                        cmd.Parameters.AddWithValue("@id", student.StudentID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
                return false;
            }
        }

        // Delete Student
        public static bool DeleteStudent(int studentId)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "DELETE FROM Students WHERE StudentID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
                return false;
            }
        }

        // Get All Students
        public static List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "SELECT * FROM Students";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentName = reader["StudentName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                GroupName = reader["GroupName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                CourseID = Convert.ToInt32(reader["CourseID"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching students: " + ex.Message);
            }

            return students;
        }
        public static Student GetStudentById(int studentId)
        {
            try
            {
                using (var conn = DBconnection.GetConnection())
                {
                    string query = "SELECT * FROM Students WHERE StudentID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Student
                                {
                                    StudentID = Convert.ToInt32(reader["StudentID"]),
                                    StudentName = reader["StudentName"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Gender = reader["Gender"].ToString(),
                                    GroupName = reader["GroupName"].ToString(),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    CourseID = Convert.ToInt32(reader["CourseID"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student details: " + ex.Message);
            }

            return null;
        }

    }
}


    

