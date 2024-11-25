using Microsoft.EntityFrameworkCore;
using StudentMVCApp.Data;

namespace StudentMVCApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentMVCAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<StudentMVCAppContext>>()))
            {
                if (context == null)
                {
                    throw new ArgumentNullException("Null context");
                }
                
                if(!context.Student.Any() && !context.Course.Any())
                {
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

                    context.Student.Add(s1);
                    context.Student.Add(s2);

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

                    context.Course.Add(c1);
                    context.Course.Add(c2);
                }
                context.SaveChanges();
            }
        }
    }
}
