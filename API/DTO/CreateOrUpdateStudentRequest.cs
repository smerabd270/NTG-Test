using System.Collections.Generic;

namespace WebAPI.DTO
{
    public class CreateOrUpdateStudentRequest
    {
        //public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }

    }
}
