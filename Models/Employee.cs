using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace EmployeeRegistrationApp.Models
{
    public class Employee
    {
        [Required]
        [StringLength(50, ErrorMessage ="Employee Id is required")]
        public string EmployeeId { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage = "Name can only contain letters & spaces.")]
        //ensures that only alpha. chars.(both upper and lower case) and space are allowed.
        //limits the length of name to 50 characters
        public string Name { get; set; } = String.Empty;

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-za-z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email format")]
        //ensures that input email and vaild email structures only are allowed.
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Department is required")]
        public string Department{ get; set; } = String.Empty;

        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set;} = String.Empty;

        [Required(ErrorMessage = "WorkLocation  is required")]
        public string WorkLocation { get; set; } = String.Empty;

        [Required(ErrorMessage = "Status  is required")]
        public string Status { get; set; } = String.Empty;
    }
}
