using EFCoreTask.Core.Domain.TaskModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTask.Core.Domain.ModelConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasMany(e => e.subordinates).WithOne(e=>e.Manager).HasForeignKey(e=>e.ManagerId);

        }
    }
}
