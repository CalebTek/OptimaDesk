using OptimaDesk.Common.Models;
using OptimaDesk.Domain.Stock;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.RetailStations
{
    /// <summary>
    /// Represents a lubricating oil tank at a retail station.
    /// </summary>
    public class LUBTank : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public string? Name { get; set; }

        public decimal? TankCapacity { get; set; }

        [Required]
        public decimal OpeningVolume { get; set; }

        [Required]
        public decimal ClosingVolume { get; set; }

        [Required]
        public decimal OpeningDip { get; set; }

        [Required]
        public decimal ClosingDip { get; set; }

        public decimal TotalQuantity => ClosingVolume - OpeningVolume;

        public decimal QuantityReceived { get; set; }

        public decimal QuantityTransferred { get; set; }

        public decimal TankSales => OpeningVolume + QuantityReceived - QuantityTransferred - ClosingVolume;

        //public string? StockPositionId { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
        //public virtual StockPosition? StockPosition { get; set; }
    }
}