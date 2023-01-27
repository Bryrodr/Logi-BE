using System.ComponentModel.DataAnnotations;

namespace Server_Side.Model
{
    public class User
    {
        [Required]
        [Key]
        public string Username { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public string Role { get; set; } = "user";

        public virtual ICollection<Order> Orders { get; set; }

    }
}
