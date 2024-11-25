using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentClassLibrary;

namespace StudentMVCApp.Data
{
    public class StudentMVCAppContext : DbContext
    {
        public StudentMVCAppContext (DbContextOptions<StudentMVCAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasKey(s => s.ID);
            modelBuilder.Entity<Student>().Property(s => s.Name).HasMaxLength(70).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Email).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Age).IsRequired();

            modelBuilder.Entity<Course>().HasKey(c => c.ID);
            modelBuilder.Entity<Course>().Property(c => c.Name).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Course>().Property(c => c.Department).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Course>().Property(c => c.Lecturer).HasMaxLength(70).IsRequired();
        }

        public DbSet<StudentClassLibrary.Student> Student { get; set; } = default!;
        public DbSet<StudentClassLibrary.Course> Course { get; set; } = default!;
    }
}
