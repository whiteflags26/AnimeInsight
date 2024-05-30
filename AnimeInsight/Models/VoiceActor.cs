using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeInsight.Models
{
    public class VoiceActor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(250)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(50)")]
        public string Gender { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
    }
}
