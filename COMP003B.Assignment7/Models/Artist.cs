using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Artist
    {
        public int ArtistId { get; set;}

        [Required]
        public string ArtistName { get; set;}

        // Collection navigation property
        public virtual ICollection<Records>? Records { get; set;}
    }
}
