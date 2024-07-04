namespace EFCoreTask.Core.Domain.TaskModel
{
    public class Teacher
    {
        public int TeacherId { get; set; }  
        public string TeacherName { get; set; }
        public string TeacherDescription { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
