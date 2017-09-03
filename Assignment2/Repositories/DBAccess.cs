using System;
namespace Assignment2.Repositories.DBAccess
{
    public class DBAccess
    {
        public DBAccess()
        {
        }
        public getCourses() {
            return new List<Course>();
        }
        public getStudentsInCourse(courseID) {
            return new List<Student>();
        }
    }
}
