using Core.DB;
using Services.DTO;
using Services.Iservices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;
using Core.Entites;

namespace Services.Services
{
    public class StudentWithCourseService : IStudentWithCourseService
    {
        private readonly IStudentService studentService;
        private readonly IStudentCourseService studentCourseService;
        private readonly CourseManagmentDb courseManagmentDb;
        public StudentWithCourseService(CourseManagmentDb courseManagmentDb, IStudentService studentService, IStudentCourseService studentCourseService)
        {
            this.studentService = studentService;
            this.courseManagmentDb = courseManagmentDb;
            this.studentCourseService = studentCourseService;
        }
        public async Task CreateStudentWithCouresesAsync(CreateOrUpdateStudentRequest createOrUpdateStudentRequest, List<CreateStudentCourseRequest> createStudentCourseRequests)
        {

            try
            {
                Student student = new Student()
                {
                    FirstName = createOrUpdateStudentRequest.FirstName,
                    LasttName = createOrUpdateStudentRequest.LastName,
                    MobileNumber = createOrUpdateStudentRequest.MobileNumber,
                };
                await studentService.CreateStudentAsync(student);
                List<StudentCourse> studentCourses = new List<StudentCourse>();
               
                foreach (CreateStudentCourseRequest studentCourse in createStudentCourseRequests)
                {
                    StudentCourse st = new StudentCourse()
                    {
                        StudentId = student.Id,
                        CourseTeacherId = studentCourse.CourseTeacherId,
                    };
                    studentCourses.Add(st);
                }
              studentCourseService.CreateListStudentCourseAsync(studentCourses);
            }
            catch
            {
                throw;


            }

        }

        public async Task<List<GetStudentsWihCouresesRequest>> GetStudentsWihtCoureses()
        {
            // List<GetStudentsWihCouresesRequest> getStudentsWihCouresesRequests = new List<GetStudentsWihCouresesRequest>();
            var result = (from sc in courseManagmentDb.StudentsCourses
                          join s in courseManagmentDb.Students on sc.StudentId equals s.Id
                          join ct in courseManagmentDb.CoursesTeachers on sc.CourseTeacherId equals ct.Id
                          join t in courseManagmentDb.teachers on ct.TeacherId equals t.Id
                          join c in courseManagmentDb.Courses on ct.CourseId equals c.Id
                          select new GetStudentsWihCouresesRequest()
                          {
                              StudentId = sc.StudentId,
                              StudentFullName = s.FirstName + " " + s.LasttName,
                              CourseId = ct.CourseId,
                              CourseName = c.Name,
                              TeacherId = ct.TeacherId,
                              TeacherName = t.Name,
                          }
                          );
            return result.ToList();
        }

        public async Task<bool> UpadteStudentWithCouresesAsync(int StudentId, CreateOrUpdateStudentRequest createOrUpdateStudentRequest, List<CreateStudentCourseRequest> createStudentCourseRequests)
        {
            Student student = new Student();
            student.Id = StudentId;
            student.FirstName = createOrUpdateStudentRequest.FirstName;
            student.LasttName = createOrUpdateStudentRequest.LastName;
            student.MobileNumber = createOrUpdateStudentRequest.MobileNumber;
            await studentService.UpdateStudentAsync(student);
            List<StudentCourse> studentCourses = new List<StudentCourse>();

            foreach (CreateStudentCourseRequest studentCourse in createStudentCourseRequests)
            {
                StudentCourse st = new StudentCourse()
                {
                    StudentId = StudentId,
                    CourseTeacherId = studentCourse.CourseTeacherId,
                };
                studentCourses.Add(st);
                 studentCourseService.CreateListStudentCourseWithCheckAsync(studentCourses);

            }


            return true;



        }
    }
}
