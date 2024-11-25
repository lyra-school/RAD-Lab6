using Microsoft.EntityFrameworkCore;

namespace StudentConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCourseContext db = new StudentCourseContext();

            StudentClassLibrary.Student s1 = new StudentClassLibrary.Student
            {
                Name = "Bob Bonson",
                Age = 69,
                Email = "ahaha@domain.com"
            };

            StudentClassLibrary.Student s2 = new StudentClassLibrary.Student
            {
                Name = "John Johnson",
                Age = 20,
                Email = "email@domain.com"
            };

            db.Student.Add(s1);
            db.Student.Add(s2);

            StudentClassLibrary.Course c1 = new StudentClassLibrary.Course
            {
                Name = "Course 1",
                Department = "Department of Learning",
                Lecturer = "Mr Killian",
                Students = [s1, s2]
            };

            StudentClassLibrary.Course c2 = new StudentClassLibrary.Course
            {
                Name = "How To Make Espresso",
                Department = "Department of Coffee",
                Lecturer = "Joe Bidone",
                Students = [s1, s2]
            };

            db.Course.Add(c1);
            db.Course.Add(c2);

            db.SaveChanges();
        }
    }
}
