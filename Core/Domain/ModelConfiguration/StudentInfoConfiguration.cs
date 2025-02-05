﻿using EFCoreTask.Core.Domain.TaskModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTask.Core.Domain.ModelConfiguration
{
    public class StudentInfoConfiguration : IEntityTypeConfiguration<StudentInfo>
    {
        public void Configure(EntityTypeBuilder<StudentInfo> builder)
        {
            builder.HasOne(i => i.Student).WithOne().HasForeignKey("StudentId");
            //builder.HasOne(u => u.Student).WithOne(u=>u.StudentBio).HasForeignKey<Student>(e=>e.Id);
            builder.HasOne(u => u.Student).WithOne().HasForeignKey("StudentId");
        }
    }
}
