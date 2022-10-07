using Microsoft.EntityFrameworkCore;


namespace StudentsRecords.Entities
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // And then with some movies:
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, FirstName = "Bart", LastName = "Simpson", DateOfBirth = Convert.ToDateTime(05/31/1971), GPA = 2.7 },
                new Student() { StudentId = 2, FirstName = "Lisa", LastName = "Simpson", DateOfBirth = Convert.ToDateTime(08/05/1973), GPA = 4.0 }
            );
        }
    }
}
