using EFCoreTask.Core.Domain.Models;
using EFCoreTask.Core.Domain.TaskModel;
using EFCoreTask.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {
            //lazy loading
            // in this behavior. it does not load the childs at the start
            var villas = context.Villas.ToList();
            foreach (var item in villas)
            {
                item.villaAmanities = context.VillaAmanities.Where(value => value.Id == item.Id).ToList();
            }


            // Eager loading get by using Includes
            var eagerVillas = context.Villas.Include(u=>u.villaAmanities).ToList();


            //explicit loading
            Villa villa = context.Villas.Where(u => u.Id == 1).FirstOrDefault();
            context.Entry(villa).Collection(u => u.villaAmanities).Load();

            return Ok(villas);


        }

        //[HttpGet("getAllEmployeeManager")]
        //public IActionResult getAllEmployeeManager() { 
        //        var employees = context.AllEmployeeManager.ToList();
        //        return Ok(employees);
        //}
        [HttpGet("getStudents")]
        public async Task<IActionResult> getStudents()
        {
            //var students = await context.Student.ToArrayAsync();

            return Ok();
        }

        //[HttpPost("AddStudent")]
        //public async Task<IActionResult> addStudents(Student student)
        //{
        //    await context.Student.AddAsync(student);
        //    await context.SaveChangesAsync();

        //    return Ok();
        //}

        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent()
        {

            //var student = context.Student;

            //var newStudent = new Student
            //{
            //    Name = "Touqeer",
            //    RollNo = "1128",
                
            //};

            //await student.AddAsync(newStudent);
            //await context.SaveChangesAsync();
            return Ok();
        }
    }
}
