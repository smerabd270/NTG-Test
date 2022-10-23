using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DB
{
    public static class DbSeeder
    {
        public static void SeedCourse(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData
                (
                new Course()
                {
                    Id = 1,
                    Name = "English",
                    StartDate = DateTime.Now.AddMonths(-3),
                    EndDate = DateTime.Now.AddMonths(+3),
                },
                new Course()
                {
                    Id = 2,
                    Name = "French",
                    StartDate = DateTime.Now.AddMonths(-3),
                    EndDate = DateTime.Now.AddMonths(+3),
                },
                  new Course()
                  {
                      Id = 3,
                      Name = "Business Administration",
                      StartDate = new DateTime(2022 - 01 - 02),
                      EndDate = new DateTime(2022 - 11 - 23),
                  },
                   new Course()
                   {
                       Id = 4,
                       Name = "ICDL",
                       StartDate = DateTime.Now.AddMonths(-3),
                       EndDate = DateTime.Now.AddMonths(+3),
                   },
                     new Course()
                     {
                         Id = 5,
                         Name = "Communication skills",
                         StartDate = DateTime.Now.AddMonths(-3),
                         EndDate = DateTime.Now.AddMonths(+3),
                     }
                );
        }
        public static void SeedTeacher(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData
                (
                new Teacher()
                {
                    Id = 1,
                    Name = "Gary Cabrera",
                    MobileNumber = "0932222789"
                },
                new Teacher()
                {
                    Id = 2,
                    Name = "Stacy Logan",
                    MobileNumber = "0932222789"
                },
                  new Teacher()
                  {
                      Id = 3,
                      Name = "Priscilla Phelps",
                      MobileNumber = "0965123456"
                  },
                  new Teacher()
                  {
                      Id = 4,
                      Name = "Aliza Vance",
                      MobileNumber = "0965123456"
                  },
                   new Teacher()
                   {
                       Id = 5,
                       Name = "Averie Carter",
                       MobileNumber = "096514577"
                   },
                    new Teacher()
                    {
                        Id = 6,
                        Name = "Savannah Brooks",
                        MobileNumber = "0988123577"
                    },
                    new Teacher()
                    {
                        Id = 7,
                        Name = "Belen Fox",
                        MobileNumber = "09651234577"
                    },
                    new Teacher()
                    {
                        Id = 8,
                        Name = "Yadira Mcintyre",
                        MobileNumber = "09671234577"
                    },
                      new Teacher()
                      {
                          Id = 9,
                          Name = "Grayson Stout",
                          MobileNumber = "09631234577"
                      }
                );
        }
        public static void SeedCourseTeacher(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>().HasData
              (
              new CourseTeacher()
              {
                  Id = 1,
                  CourseId = 1,
                  TeacherId = 1
              },
              new CourseTeacher()
              {
                  Id = 2,
                  CourseId = 1,
                  TeacherId = 2
              },
              new CourseTeacher()
              {
                  Id = 3,
                  CourseId = 1,
                  TeacherId = 3
              },
               new CourseTeacher()
               {
                   Id = 4,
                   CourseId = 2,
                   TeacherId = 4
               },
                new CourseTeacher()
                {
                    Id = 5,
                    CourseId = 2,
                    TeacherId = 3
                },
                new CourseTeacher()
                {
                    Id = 6,
                    CourseId = 3,
                    TeacherId = 5
                },
                new CourseTeacher()
                {
                    Id = 7,
                    CourseId = 4,
                    TeacherId = 6
                },
                 new CourseTeacher()
                 {
                     Id = 8,
                     CourseId = 4,
                     TeacherId = 7
                 },
                  new CourseTeacher()
                  {
                      Id = 9,
                      CourseId = 5,
                      TeacherId = 8
                  },

                  new CourseTeacher()
                  {
                      Id = 10,
                      CourseId = 5,
                      TeacherId = 7
                  }


              );
        }
    }
}
