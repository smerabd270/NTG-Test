using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DB
{
    public class CourseManagmentDb : DbContext
    {
        public CourseManagmentDb(DbContextOptions<CourseManagmentDb> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher>teachers { get; set; }
        public DbSet<CourseTeacher> CoursesTeachers { get; set; }

        public DbSet<StudentCourse> StudentsCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedCourse();
            modelBuilder.SeedTeacher();
            modelBuilder.SeedCourseTeacher();


        }



    }
}
