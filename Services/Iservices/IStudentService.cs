using Core.Entites;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Iservices
{
    public interface  IStudentService
    {
        Task CreateStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);

    }
}
