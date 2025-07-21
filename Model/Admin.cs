using System.ComponentModel.DataAnnotations;

namespace JobPortal.Model
{
    public class Admin
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public string PhoneNumber { get; set; } 
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Admin() { }
    }
}
