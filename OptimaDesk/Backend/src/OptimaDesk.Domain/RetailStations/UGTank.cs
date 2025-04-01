using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.Stock;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.RetailStations
{
    /// <summary>
    /// Represents an underground tank at a retail station.
    /// </summary>
    public class UGTank : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public ProductType Type { get; set; }

        [Required]
        public decimal Capacity { get; set; }

        [Required]
        public decimal OpeningStock { get; set; }

        [Required]
        public decimal ClosingStock { get; set; }

        public decimal ProductReceived { get; set; }

        public decimal TankSales => OpeningStock + ProductReceived - ClosingStock;

        //public string? StockPositionId { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
        //public virtual StockPosition? StockPosition { get; set; }
    }
}