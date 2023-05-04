using _1.eTickers.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace _1.eTickers.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "{0} is required")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }

        [Display(Name = "Cinema Desciption")]
        [Required(ErrorMessage = "{0} is required")]
        public string Description { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
