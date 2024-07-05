namespace EFCoreTask.Core.Domain.TaskModel
{
    public class StudentInfo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string FSCMarksPercentage { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
