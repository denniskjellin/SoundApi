using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundApi.Models
{

    public class Music
    {
        // Properties
        public int MusicId { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Length { get; set; }

        // Setting a foreign key property (connecting Music and genre)
        public int GenreId { get; set; }

        // Setting a navigation property (get the genre)
        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }
    }

    public class Genre
    {
        // Properties
        public int GenreId { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }
}