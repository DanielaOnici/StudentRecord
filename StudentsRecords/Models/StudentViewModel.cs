using StudentsRecords.Entities;
using System;
using System.Globalization;

namespace StudentsRecords.Models
{
    public class StudentViewModel
    {
        public Student? ActiveStudent { get; set; }

        public int Age => (DateTime.Today - ActiveStudent.DateOfBirth).Days / 365;

        public string Scale {get {
                if(ActiveStudent.GPA == 4)
                {
                    return "Excellent";
                }
                else if(ActiveStudent.GPA >= 3.5 || ActiveStudent.GPA <= 3.9) 
                {
                    return "Very Good";
                }
                else if(ActiveStudent.GPA >= 3 || ActiveStudent.GPA <= 3.4)
                {
                    return "Good";
                }
                else if(ActiveStudent.GPA >= 2.5 || ActiveStudent.GPA <= 2.9)
                {
                    return "Satisfactory";
                }
                else
                {
                    return "Unsatisfactory";
                }
            } }

    }
}
