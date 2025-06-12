using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Repositories
{
    internal class DataBaseManager
    {


        public static void CreateTables()
        {
            using (var conn = DBconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY,
                        CourseName TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER PRIMARY KEY,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        LecturerID INTEGER PRIMARY KEY,
                        LecturerName TEXT NOT NULL,
                        SubjectID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY,
                        StudentName TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY,
                        ExamName TEXT NOT NULL,
                        SubjectID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Marks (
                        MarkID INTEGER PRIMARY KEY,
                        StudentID INTEGER,
                        ExamID INTEGER,
                        Score INTEGER,
                        FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomID INTEGER PRIMARY KEY,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Timetables (
                        TimetableID INTEGER PRIMARY KEY,
                        SubjectID INTEGER,
                        TimeSlot TEXT NOT NULL,
                        RoomID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
                    );



                ";
                cmd.ExecuteNonQuery();
            }
}
