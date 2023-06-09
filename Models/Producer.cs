using ProjetoYoutube.Data.Base;
using ProjetoYoutube.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoYoutube.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
