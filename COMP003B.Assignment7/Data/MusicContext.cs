using COMP003B.Assignment7.Models;
using Microsoft.EntityFrameworkCore;
namespace COMP003B.Assignment7.Data
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : 
            base(options) 
        { 
        }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Records> Records { get; set; }
    }
}
