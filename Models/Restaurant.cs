using ProductAPI.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class Restaurant:BaseAuditibleEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }

    }
}
