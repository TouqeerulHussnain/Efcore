using EFCoreTask.Core.Domain.TaskModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTask.Core.Domain.ModelConfiguration
{
    public class AdmissionFormConfiguration : IEntityTypeConfiguration<StudentAdmissionForm>
    {
        public void Configure(EntityTypeBuilder<StudentAdmissionForm> builder)
        {
            builder.HasKey(e => e.Id);
            //builder.HasOne(e=>e.Student).WithOne(t=>t.RollNo)
        }
    }
}
