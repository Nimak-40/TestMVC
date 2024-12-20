using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0.01,2000)]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
