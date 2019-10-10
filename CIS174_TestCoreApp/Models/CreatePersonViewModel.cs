using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required][StringLength(25)] public string FirstName { get; set; }

        [Required][StringLength(25)] public string MiddleName { get; set; }

        [Required][StringLength(25)] public string LastName { get; set; }

        [Required][Range(1, 20)] public int Age { get; set; }

        [Required][EmailAddress] public string Email { get; set; }

        [Required][Compare("Email")] public string ConfirmEmail { get; set; }

        [Required] [Url] [StringLength(7)] public string Website { get; set; }

         public string School { get; set; }
    }
}
