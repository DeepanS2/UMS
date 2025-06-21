using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagement_Project.Repositories
{
        public static class Data
        {
            public static void CreateTables(SQLiteConnection connection)
            {
                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL,
                    Role TEXT CHECK (Role IN ('Admin', 'Staff', 'Student', 'Lecturer'))

                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Courses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT
                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Subjects (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT,
                    CourseId INTEGER,
                    FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Students (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    CourseId INTEGER,
                    FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Exams (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT,
                    SubjectId INTEGER,
                    ExamDate TEXT,
                    FOREIGN KEY(SubjectId) REFERENCES Subjects(Id)
                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Marks (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER,
                    ExamId INTEGER,
                    Score INTEGER,
                    FOREIGN KEY(StudentId) REFERENCES Students(Id),
                    FOREIGN KEY(ExamId) REFERENCES Exams(Id)
                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Rooms (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT,
                    RoomType TEXT
                );");

                Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Timetables (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectId INTEGER,
                    Lecturer TEXT,
                    RoomId INTEGER,
                    TimeSlot TEXT,
                    FOREIGN KEY(SubjectId) REFERENCES Subjects(Id),
                    FOREIGN KEY(RoomId) REFERENCES Rooms(Id)
                );");

            Execute(connection, @"
                    CREATE TABLE IF NOT EXISTS Staff (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StaffName TEXT,
                        Password TEXT
                    );");

        }

        private static void Execute(SQLiteConnection connection, string createQuery)
            {
                using (var command = new SQLiteCommand(createQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    

}




