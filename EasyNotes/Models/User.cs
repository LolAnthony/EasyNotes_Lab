namespace EasyNotes.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        public string Password { get; set; }
    }
}
