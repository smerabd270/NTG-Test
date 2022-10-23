using Core.DB;
using Core.Entites;
using Services.Iservices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Services.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly CourseManagmentDb courseManagmentDb;
        public StudentCourseService(CourseManagmentDb courseManagmentDb)
        {
            this.courseManagmentDb = courseManagmentDb;
        }
        public async Task CreateListStudentCourseWithCheckAsync(List<StudentCourse> studentCourses)
        {
            try
            {
                StudentCourse st = new StudentCourse();
                foreach (StudentCourse sc in studentCourses)
                {
                    st = (from s in courseManagmentDb.StudentsCourses where s.StudentId == sc.StudentId && s.CourseTeacherId == sc.CourseTeacherId select s).FirstOrDefault();
                    if (st != null)
                    {
                        studentCourses.Remove(sc);
                    }

                }
                courseManagmentDb.AddRange(studentCourses);
                courseManagmentDb.SaveChanges();

            }
            catch
            {
                throw;
            }
        }
        public async Task CreateListStudentCourseAsync(List<StudentCourse> studentCourses)
        {
            try
            {
                courseManagmentDb.AddRange(studentCourses);
                courseManagmentDb.SaveChanges();
            }
            catch
            {
                throw;
            }

        }
    }
}
