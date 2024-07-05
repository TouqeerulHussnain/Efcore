
using EFCoreTask.Core.Domain.ModelConfiguration;
using EFCoreTask.Core.Domain.Models;
using EFCoreTask.Core.Domain.TaskModel;
using EFCoreTask.Core.Domain.View;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTask.Core.Repository
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
            
        }

        //public DbSet<Student> Student { get; set; }
        //public DbSet<StudentInfo> StudentInfo { get; set; }
        //public DbSet<StudentAdmissionForm> StudentAdmissionForm { get; set; }
        //public DbSet<AllEmployeeManager> AllEmployeeManager { get; set; }
        public DbSet<VillaAmanity> VillaAmanities { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<AllEmployeeManager>().ToView(nameof(AllEmployeeManager));
            //new StudentConfiguration().Configure(modelBuilder.Entity<Student>());
            //modelBuilder.ApplyConfiguration(new StudentBioConfiguration());
            //modelBuilder.ApplyConfiguration(new AdmissionFormConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            modelBuilder.Entity<Villa>(
                    entity =>
                    {
                        //entity.HasMany(i =>i.villaAmanities).WithOne(v=>v.Villa).HasForeignKey("VillaId");
                        entity.HasMany(i => i.villaAmanities).WithOne(v => v.Villa);
                    }
                );
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Price = 200,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Decent Villa",
                    Price = 400,
                }


                );

            modelBuilder.Entity<VillaAmanity>().HasData(
                new VillaAmanity
                {
                    Id = 1,
                    VillaId = 1,

                    Name = "Pool"
                },
                new VillaAmanity
                {
                    Id = 2,
                    VillaId = 1,

                    Name = "Microwave oven"
                },
                new VillaAmanity
                {
                    Id = 3,
                    VillaId = 2,

                    Name = "Bed"
                },


                new VillaAmanity
                {
                    Id = 4,
                    VillaId = 1,

                    Name = "Library room"
                });
        }
    }
}
