using System.ComponentModel.DataAnnotations;

namespace SMS_Web_App_Version.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(8, 60)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public string Course { get; set; }
    }
}
