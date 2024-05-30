using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeInsight.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(250)")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar2(100)")]
        public string Type { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Episode count should be greater than 0")]
        public int EpisodeCount { get; set; }


        [Column(TypeName = "nvarchar2(2000)")] 
        public string? Description { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Duration should be greater than 0")]
        public int Duration { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
    }
}
