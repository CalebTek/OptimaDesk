using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
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

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}