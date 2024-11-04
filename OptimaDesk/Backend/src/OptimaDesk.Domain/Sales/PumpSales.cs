using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Sales
{
    /// <summary>
    /// Represents pump sales data for a retail station.
    /// </summary>
    public class PumpSales : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Collections of pumps related to PMS and AGO sales
        public virtual ICollection<Pump>? PMSPumps { get; set; } = new List<Pump>();
        public virtual ICollection<Pump>? AGOPumps { get; set; } = new List<Pump>();

        public decimal? PMSTotalRTT { get; set; }
        public decimal? PMSTotalSales { get; set; }
        public decimal? PMSTotalActualSales { get; set; }

        public decimal? AGOTotalRTT { get; set; }
        public decimal? AGOTotalSales { get; set; }
        public decimal? AGOTotalActualSales { get; set; }

        [Required]
        public decimal PMSPrice { get; set; }

        [Required]
        public decimal AGOPrice { get; set; }

        public decimal? PMSSalesAmount { get; set; }
        public decimal? AGOSalesAmount { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
