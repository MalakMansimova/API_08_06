namespace ProductAPI.Models.Common
{
    public class BaseAuditibleEntity:BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
