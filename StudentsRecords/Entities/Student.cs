using System.ComponentModel.DataAnnotations;

namespace StudentsRecords.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        // Requires the first name
        [Required(ErrorMessage = "Please add the first name.")]
        public string? FirstName { get; set; }

        // Requires the last name
        [Required(ErrorMessage = "Please add the last name.")]
        public string? LastName { get; set; }

        // Requires the birth date
        [Required(ErrorMessage = "Please add the birth date.")]
        public DateTime? DateOfBirth { get; set; }

        // Requires the GPA between 0 to 4
        [Required(ErrorMessage = "Please add your GPA.")]
        [Range(0, 4, ErrorMessage = "GPA must be between 0 to 4.")]
        public double? GPA { get; set; }

    }
}
