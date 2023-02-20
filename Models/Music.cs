using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundApi.Models
{

    public class Music
    {
        // Properties
        public int Id { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Length { get; set; }

        // Include GenreId as a foreign key
        [Required]
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        // Genre navigation property
        public Genre? Genre { get; set; }

    }

    public class Genre
    {
        // Properties
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}