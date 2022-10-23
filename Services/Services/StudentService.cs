using Core.DB;
using Core.Entites;
using Services.DTO;
using Services.Iservices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly CourseManagmentDb courseManagmentDb;
        public StudentService(CourseManagmentDb courseManagmentDb)
        {
            this.courseManagmentDb = courseManagmentDb;
        }
        public async Task CreateStudentAsync(Student student)
        {
            try
            {

                await courseManagmentDb.Students.AddAsync(student);
                await courseManagmentDb.SaveChangesAsync();


            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public async Task UpdateStudentAsync(Student student)
        {
            try
            {
                Student studentToUpdate = await courseManagmentDb.Students.FindAsync(student.Id);
                studentToUpdate.FirstName = student.FirstName;
                studentToUpdate.LasttName = student.LasttName;
                studentToUpdate.MobileNumber = student.MobileNumber;
                student.UpdatedDate = DateTime.Now;
                courseManagmentDb.Students.Update(studentToUpdate);
               await courseManagmentDb.SaveChangesAsync();


            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
