using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Iservices
{
    public  interface IStudentCourseService
    {
        Task CreateListStudentCourseWithCheckAsync(List<StudentCourse> studentCourses);
        Task CreateListStudentCourseAsync(List<StudentCourse> studentCourses);


    }
}
