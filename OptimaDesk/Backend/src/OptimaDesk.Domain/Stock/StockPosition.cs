using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Stock
{
    /// <summary>
    /// Represents the stock position for a retail station.
    /// </summary>
    public class StockPosition : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Collections of tanks related to PMS, AGO, and LUB
        public virtual ICollection<UGTank>? PMSTanks { get; set; } = new List<UGTank>();
        public virtual ICollection<UGTank>? AGOTanks { get; set; } = new List<UGTank>();
        public virtual ICollection<LUBTank>? LUBTanks { get; set; } = new List<LUBTank>();

        // PMS-related totals
        public decimal PMSTotalOpeningVolume { get; set; }
        public decimal PMSTotalClosingVolume { get; set; }
        public decimal PMSTotalProductReceived { get; set; }
        public decimal PMSTotalTankSales { get; set; }

        // AGO-related totals
        public decimal AGOTotalOpeningVolume { get; set; }
        public decimal AGOTotalClosingVolume { get; set; }
        public decimal AGOTotalProductReceived { get; set; }
        public decimal AGOTotalTankSales { get; set; }

        // LUB-related totals
        public decimal LUBTotalOpeningVolume { get; set; }
        public decimal LUBTotalClosingVolume { get; set; }
        public decimal LUBTotalProductReceived { get; set; }
        public decimal LUBTotalTankSales { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
