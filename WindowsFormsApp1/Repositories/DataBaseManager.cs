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
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Username TEXT NOT NULL UNIQUE,
                        Password ,
                        Role TEXT NOT NULL CHECK (Role IN ('Admin', 'Staff', 'Lecturer', 'Student'))
                      
                    );

                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL UNIQUE
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER NOT NULL,
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LecturerName TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        Gender TEXT NOT NULL,
                        Age INTEGER,
                        SubjectID INTEGER NOT NULL,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        Age INTEGER,
                        Gender TEXT NOT NULL CHECK (Gender IN ('Male', 'Female')),
                        GroupName TEXT NOT NULL CHECK (GroupName IN ('A', 'B')),
                        CourseID INTEGER NOT NULL,
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        ExamDate TEXT NOT NULL, 
                        ExamStartTime TEXT NOT NULL, 
                        ExamEndTime TEXT NOT NULL, 
                        SubjectID INTEGER NOT NULL,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Marks (
                        MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER NOT NULL,
                        ExamID INTEGER NOT NULL,
                        Score INTEGER CHECK (Score BETWEEN 0 AND 100),
                        FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL UNIQUE,
                        RoomType TEXT NOT NULL CHECK (RoomType IN ('Lab', 'Hall'))

                    );

                    CREATE TABLE IF NOT EXISTS Timetables (
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectID INTEGER NOT NULL,
                        TimeSlot TEXT NOT NULL,
                        RoomID INTEGER NOT NULL,
                        GroupName TEXT NOT NULL,
                        LecturerID INTEGER NOT NULL,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
                        FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID)
                    );

                        


                ";
                cmd.ExecuteNonQuery();

                 var insertCmd = conn.CreateCommand();
                    insertCmd.CommandText = @"
                        INSERT OR IGNORE INTO Users (Username, Password, Role,Name,Address)
                        VALUES ('admin', 'admin123', 'Admin','Admin','jaffna');
                    ";
                    insertCmd.ExecuteNonQuery();


            }

        }    
    }
}
