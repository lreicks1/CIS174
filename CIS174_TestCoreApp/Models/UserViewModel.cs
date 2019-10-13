using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class UserViewModel
    {
        [Required] [StringLength(25)] public string FirstName { get; set; }
      //  <label asp-for="FirstName"></label>

        [Required] [StringLength(25)] public string LastName { get; set; }

        [Required] public int Age { get; set; }

        [Required] public string DateOfBirth { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }

        [Required] [Compare("ConfirmPassword")] public string Password { get; set; }

        [Required] [Compare("Password")] public string ConfirmPassword { get; set; }

        [Required][StringLength(7)] public string Country { get; set; }

       // public string School { get; set; }
    }
}
