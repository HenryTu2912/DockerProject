using System.ComponentModel.DataAnnotations;

namespace DraftGoods.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
