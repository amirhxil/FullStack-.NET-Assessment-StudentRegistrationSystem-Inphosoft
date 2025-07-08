
namespace StudentRegistrationSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }

}
