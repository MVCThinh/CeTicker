using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace _1.eTickers.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="{0} is required")]
        public string FullName { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "{0} is required")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
