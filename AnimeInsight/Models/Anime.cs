using System.ComponentModel.DataAnnotations;

namespace AnimeInsight.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        public int Duration { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
