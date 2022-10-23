using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entites
{
    public class CourseTeacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int  CourseId { get; set; }
        public int TeacherId { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }



    }
}
