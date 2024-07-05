namespace EFCoreTask.Core.Domain.TaskModel
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }

        //public Guid? StudentInfoId { get; set; }
        //public StudentInfo? studentInfo { get; set; }

        //public ICollection<StudentAdmissionForm>? admissionForms { get; set; }

        //public ICollection<Teacher>? Teachers { get; set; }  
    }
}
