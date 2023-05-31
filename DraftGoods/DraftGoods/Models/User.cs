using System.ComponentModel.DataAnnotations;

namespace DraftGoods.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
