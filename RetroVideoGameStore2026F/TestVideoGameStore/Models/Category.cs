using System.ComponentModel.DataAnnotations;

namespace TestVideoGameStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
