using Microsoft.EntityFrameworkCore;
using StudentClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    public class StudentCourseContext : DbContext
    {
        public StudentCourseContext() { }
        public StudentCourseContext (DbContextOptions<StudentCourseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=C:\\Users\\Some User\\OneDrive - Atlantic TU\\Rich App Dev\\Lab6\\StudentConsoleApp\\students.db");
        }

        public DbSet<StudentClassLibrary.Student> Student { get; set; } = default!;
        public DbSet<StudentClassLibrary.Course> Course { get; set; } = default!;
    }
}
