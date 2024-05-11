namespace COMP003B.Assignment7.Models
{
    public class Records
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }

        public int SongId { get; set; }

        // Nullable navigation properties
        public virtual Song? Songs { get; set; }

        public virtual Artist? Artist { get; set; }
    }
}
