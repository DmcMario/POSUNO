using System.ComponentModel.DataAnnotations;

namespace POSUNO.api.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Stock { get; set; }

        public User User { get; set; }
    }
}
