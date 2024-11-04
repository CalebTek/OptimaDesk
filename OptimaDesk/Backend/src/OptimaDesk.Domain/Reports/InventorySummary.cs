using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Reports
{
    /// <summary>
    /// Represents an inventory summary for a retail station.
    /// </summary>
    public class InventorySummary : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        public DateTime Date { get; set; }

        public decimal PMSClosingStock { get; set; }

        public decimal AGOClosingStock { get; set; }

        public decimal LUBClosingStock { get; set; }

        public decimal? PMSPumpSales { get; set; }

        public decimal? AGOPumpSales { get; set; }

        public decimal? LUBSales { get; set; }

        public decimal? PMSGenUsage { get; set; }

        public decimal? AGOGenUsage { get; set; }

        public decimal? AGOToTruck { get; set; }

        public decimal? PrepaidSales { get; set; }

        public decimal? TotalPMSSales { get; set; }

        public decimal? TotalAGOSales { get; set; }

        public decimal? PMSPriceChange { get; set; }

        public decimal? AGOPriceChange { get; set; }

        public decimal? LUBPriceChange { get; set; }

        public virtual RetailStation? Station { get; set; }
    }
}
