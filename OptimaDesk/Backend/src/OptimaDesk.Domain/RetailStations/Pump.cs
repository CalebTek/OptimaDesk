using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.RetailStations
{
    /// <summary>
    /// Represents a pump at a retail station.
    /// </summary>
    public class Pump : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Model { get; set; }

        [Required]
        public ProductType Type { get; set; }

        [Required]
        public decimal OpeningMeter { get; set; }

        [Required]
        public decimal ClosingMeter { get; set; }

        public decimal Totalizer => ClosingMeter - OpeningMeter;

        public decimal RTT { get; set; } 

        public decimal TotalSales { get; set; }

        public decimal ActualSales => TotalSales - RTT; 

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}