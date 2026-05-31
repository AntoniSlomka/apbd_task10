using System.ComponentModel.DataAnnotations;

namespace apbdtask10_v2.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(48, MinimumLength = 8, ErrorMessage = "The password must be between {2} and {1} characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
