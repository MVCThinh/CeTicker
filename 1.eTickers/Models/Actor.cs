using _1.eTickers.Data.Base;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace _1.eTickers.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage =" is required")]
        public string ProfileURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "{0} is required")]
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
