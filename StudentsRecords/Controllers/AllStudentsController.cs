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
            return View();
        }

        private StudentDbContext _studentDbContext;
    }
}
