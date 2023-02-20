namespace SoundApi.Models {

    public class Music {
        // Properties
        public int Id { get; set; }
        public string? Artist { get; set; }
        public string? Title { get; set; }
        public int? Length { get; set; }

        public Genre? MusicGenre { get; set; }

    }

    public class Genre {
        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}