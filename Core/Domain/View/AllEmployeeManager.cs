using EFCoreTask.Core.Domain.TaskModel;

namespace EFCoreTask.Core.Domain.View
{
    public class AllEmployeeManager
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Guid ManagerId { get; set; }
        public Employee Manager { get; set; }
    }
}
