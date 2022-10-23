using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public  class StudentCoureses
    {
      public  CreateOrUpdateStudentRequest Student { get; set; }
   
       public List<CreateStudentCourseRequest> Coureses { get; set; }
    }
}
