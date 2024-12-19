using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; } = new List<Course>();

    public class Course
    {
        public string CourseName { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();
    }

    public List<Course> GetAllCourses()
    {
        return EnrolledCourses;
    }
}