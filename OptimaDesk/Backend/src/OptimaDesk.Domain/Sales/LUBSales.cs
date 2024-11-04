using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Sales
{
    /// <summary>
    /// Represents lubricating oil sales data for a retail station.
    /// </summary>
    public class LUBSales : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal OpeningStock { get; set; }

        [Required]
        public decimal ClosingStock { get; set; }

        public decimal ProductReceived { get; set; }

        public decimal? TotalSales { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? SalesAmount { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
