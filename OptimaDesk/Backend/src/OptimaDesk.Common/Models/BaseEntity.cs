using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Common.Models
{
    /// <summary>
    /// Base entity class representing common properties for all entities.
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsDeleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Version { get; set; }
    }
}
