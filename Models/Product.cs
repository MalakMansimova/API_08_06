using ProductAPI.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class Product:BaseAuditibleEntity
    {
        [Required]
        [MaxLength(70)]
        public string Name { get; set; } 
        public double Price { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}
