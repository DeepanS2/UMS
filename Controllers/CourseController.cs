using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagement_Project.Models;

namespace UnicomTICManagement_Project.Controllers
{
    internal class CourseController
    {
        public static List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var connection = Repositories.DatabaseManager.GetConnection())
            {
                connection.Open();
                var query = "SELECT Id, CourseName FROM Courses";
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            Id = reader.GetInt32(0),
                            CourseName = reader.GetString(1)
                        });
                    }
                }
            }

            return courses;
        }
        public static bool AddCourse(string courseName)
        {
            using (var connection = Repositories.DatabaseManager.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Courses (CourseName) VALUES (@name)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", courseName);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool UpdateCourse(int courseId, string newCourseName)
        {
            using (var connection = Repositories.DatabaseManager.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Courses SET CourseName = @name WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", newCourseName);
                    cmd.Parameters.AddWithValue("@id", courseId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool DeleteCourse(int courseId)
        {
            using (var connection = Repositories.DatabaseManager.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Courses WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", courseId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


    }
}
