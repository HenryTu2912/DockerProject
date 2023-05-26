using System.ComponentModel.DataAnnotations;

namespace DraftGoods.Models
{
    public class Item
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; } = null!;
        public float Price { get; set; }
    }
}
