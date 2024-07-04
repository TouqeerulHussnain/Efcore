namespace EFCoreTask.Core.Domain.TaskModel
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ManagerId { get; set; }
        public Employee? Manager { get; set; }
        public ICollection<Employee> subordinates { get; set; }
    }
}
