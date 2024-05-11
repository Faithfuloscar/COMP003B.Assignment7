using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Song
    {
        public int SongId { get; set; }

        [Required]
        public string SongName { get; set;}
        
        // Collection navigation property
        public virtual ICollection <Records>? Records { get; set; }

    }
}
