using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Users
{
    public class StationManager : BaseEntity
    {
        [Required]
        public string? AppUserId { get; set; }

        [Required]
        public string? RetailStationId { get; set; }

        [EmailAddress]
        public string? CompanyEmail { get; set; }

        // Navigation properties
        public virtual RetailStation? Station { get; set; }
        public virtual AppUser? AppUser { get; set; }
    }
}
