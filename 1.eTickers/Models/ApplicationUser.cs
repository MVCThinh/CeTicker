using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _1.eTickers.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
    }
}
