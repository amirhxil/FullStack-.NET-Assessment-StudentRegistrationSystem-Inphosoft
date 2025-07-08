namespace StudentRegistrationSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using StudentRegistrationSystem.Models;

    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }

}
