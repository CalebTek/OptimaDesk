using OptimaDesk.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.RetailStations
{
    /// <summary>
    /// Represents a retail station.
    /// </summary>
    public class RetailStation : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Region { get; set; }

        // Location is a calculated property based on State and City
        public string Location => $"{State}, {City}";

        [Required]
        public string? State { get; set; }

        [Required]
        public string? City { get; set; }

        // Total number of pumps calculated from individual counts
        public int TotalNoOfPump => NoOfAGO + NoOfPMS;

        [Required]
        public int NoOfAGO { get; set; }

        [Required]
        public int NoOfPMS { get; set; }

        public decimal? LUBCapacity { get; set; }

        public int TotalNoOfTanks { get; set; }

        [Required]
        public decimal TankCapacity { get; set; }

        public decimal CurrentPMS { get; set; }

        public decimal CurrentAGO { get; set; }

        public decimal CurrentLUB { get; set; }

        // Navigation properties
        public virtual ICollection<Pump>? Pumps { get; set; } = new List<Pump>();
        public virtual ICollection<UGTank>? Tanks { get; set; } = new List<UGTank>();
        public virtual ICollection<LUBTank>? Lubricants { get; set; } = new List<LUBTank>();
    }
}
