using Microsoft.AspNetCore.Mvc;
using StudentsRecords.Entities;

namespace StudentsRecords.Controllers
{
    public class AllStudentsController : Controller
    {
        public AllStudentsController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        public IActionResult AllStudents()
        {
            List<Student> student = _studentDbContext.Students.OrderBy(s => s.FirstName).ToList();
            return View(student);
        }

        private StudentDbContext _studentDbContext;
    }
}
