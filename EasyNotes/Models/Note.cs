using System.ComponentModel.DataAnnotations;

namespace EasyNotes.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        [Required]
        [MaxLength(256)]
        public string Content { get; set; }

        [Required]
        public bool Solved { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
