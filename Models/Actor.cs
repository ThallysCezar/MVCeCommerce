using ProjetoYoutube.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ProjetoYoutube.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "FullNameis required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Full name must be between 3 and 50 chars")]
        public string? FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Bio { get; set; }
        
        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
