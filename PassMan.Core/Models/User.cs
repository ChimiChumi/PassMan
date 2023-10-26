using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassMan.Models
{
    [Table("users")]
    public class User
    {
        public User(string username, string email, string password)
        {
            UserName = username;
            Email = email;
            PassWord = password;
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string PassWord { get; set; } = null!;
    }
}
