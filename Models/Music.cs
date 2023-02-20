using System.ComponentModel.DataAnnotations;

namespace SoundApi.Models {

    public class Music {
        // Properties
        public int Id { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Length { get; set; }
        public Genre? MusicGenre { get; set; }

    }

    public class Genre {
        // Properties
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}