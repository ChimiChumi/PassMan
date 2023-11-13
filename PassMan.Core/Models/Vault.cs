using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassMan.Models
{
    public class Vault
    {
        public Vault(int userId, string username, string website, string password)
        {
            UserId = userId;
            UserName = username;
            WebSite = website;
            PassWord = password;
        }

        [Key]
        public int VaultId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string WebSite { get; set; } = null!;

        [Required]
        public string PassWord { get; set; } = null!;
    }
}