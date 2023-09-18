using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiterkiWeb.Models
{
    [Table("Literki")]
    public class Literki
    {
        [Key]
        [DisplayFormat(DataFormatString = "{0:0}")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Nazwa { get; set; }
        public String PictureUrl { get; set; }
        public String SoundUrl { get; set; }
    }
}
