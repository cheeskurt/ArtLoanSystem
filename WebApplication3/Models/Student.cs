using WebApplication3.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    // An enum declaring dropdown options.
    public enum Class
    {
        B1,
        B2,
        B3,
        B4,
        B5,
        B6
    }

    public class Student
    {

        [Key]
        public int StudentID { get; set; }

        // The field is marked as required, mandating that this field is filled. A maximum length of 30 is configured for the student's first name.
        [Required(ErrorMessage = "Students first name is required."), StringLength(30, ErrorMessage = "First name cant be longer than 30 characters.")]
        public string FirstName { get; set; }

        // The field is marked as required, mandating that this field is filled. A maximum length of 30 is configured for the student's last name.
        [Required(ErrorMessage = "Student's last name is required."), StringLength(30, ErrorMessage = "Last name cant be longer than 30 characters.")]
        public string LastName { get; set; }

        // The field is marked as required, mandating that a choice from the dropdown is selected.
        [Required(ErrorMessage = "Student's class is required.")]
        public Class Class { get; set; }

    }
}
