using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundApi.Models {

    public class Music {
        // Properties
        public int MusicId { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Length { get; set; }
        [Required]
        [ForeignKey("MusicGenre")]
        public int GenreId { get; set; }
        public Genre? MusicGenre { get; set; }

    }

    public class Genre {
        // Properties
        public int GenreId { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}