using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Stock
{
    /// <summary>
    /// Represents stock reconciliation for a retail station.
    /// </summary>
    public class StockReconciliation : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public decimal PMSPumpSales { get; set; }
        public decimal AGOPumpSales { get; set; }
        public decimal LUBSales { get; set; }
        public decimal PMSUGTankSales { get; set; }
        public decimal AGOUGTankSales { get; set; }
        public decimal LUBPACKSales { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
