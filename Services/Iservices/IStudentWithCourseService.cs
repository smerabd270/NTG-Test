using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.DTO;

namespace Services.Iservices
{
    public interface IStudentWithCourseService
    {
        Task<List<GetStudentsWihCouresesRequest>> GetStudentsWihtCoureses();
        Task CreateStudentWithCouresesAsync(CreateOrUpdateStudentRequest createOrUpdateStudentRequest, List<CreateStudentCourseRequest> createStudentCourseRequests);
        Task<bool> UpadteStudentWithCouresesAsync(int StudentId, CreateOrUpdateStudentRequest createOrUpdateStudentRequest, List<CreateStudentCourseRequest> createStudentCourseRequests);



    }
}
