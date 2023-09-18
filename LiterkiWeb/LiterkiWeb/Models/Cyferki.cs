using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiterkiWeb.Models
{
    public class Cyferki
    {
        [Key]
        public Int32 Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Nazwa { get; set; }
        public String PictureUrl { get; set; }
        public String SoundUrl { get; set; }
    }
}
