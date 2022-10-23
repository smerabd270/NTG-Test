namespace Services.DTO
{
    public class GetStudentsWihCouresesRequest
    {
        public int StudentId { get; set; }
        public string StudentFullName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }


    }
}
