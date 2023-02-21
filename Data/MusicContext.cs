using Microsoft.EntityFrameworkCore;
using SoundApi.Models;

namespace SoundApi.Data {
    public class MusicContext : DbContext {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) { 

        } 
        // Table names and property
        public DbSet<Music> Musics { get; set; } 
        public DbSet<Genre> Genres { get; set; }
    }
}