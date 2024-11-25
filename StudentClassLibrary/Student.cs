using System.Reflection;

namespace StudentClassLibrary
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
