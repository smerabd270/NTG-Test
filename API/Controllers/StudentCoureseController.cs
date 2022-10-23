using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Iservices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCoureseController : ControllerBase
    {
        private readonly IStudentWithCourseService studentWithCourseService;
        public StudentCoureseController(IStudentWithCourseService studentWithCourseService)
        {
            this.studentWithCourseService = studentWithCourseService;
        }

        [HttpGet  ]
        [Route("GetStudentsWithCoursers")]
        public async Task<IActionResult> GetStudentsWithCoursers()
        {
            var StudentsCourses = await studentWithCourseService.GetStudentsWihtCoureses();
            return Ok(StudentsCourses);
        }


        [HttpPost]
        [Route("CreateStudentWithCoursers")]

        public async Task<IActionResult> CreateStudentWithCoursers([FromBody] StudentCoureses student)
        { 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await studentWithCourseService.CreateStudentWithCouresesAsync(student.Student,student.Coureses);
            return Ok("Student with chosen coureses added sucssefully");
        }
        [HttpPost]

        [Route("UpdateStudentWithCoursers/{id:int}")]

        public async Task<IActionResult> UpdateStudentWithCoursers( int id,[FromBody] StudentCoureses student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await studentWithCourseService.UpadteStudentWithCouresesAsync(id,student.Student, student.Coureses);
            return Ok("Student with chosen coureses updated sucssefully");
        }            


    }
}
