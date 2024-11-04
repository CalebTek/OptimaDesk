using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Reports
{
    /// <summary>
    /// Represents the product tracking details at a retail station.
    /// </summary>
    public class ProductTracker : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        public DateTime LoadingDate { get; set; }

        public DateTime DateReceived { get; set; }

        public string? WaybillNo { get; set; }

        public string? StationLocation { get; set; }

        public string? LoadingTicketNo { get; set; }

        public string? Transporter { get; set; }

        public string? TruckNo { get; set; }

        public ProductType Product { get; set; }

        public decimal QuantityReceived { get; set; }

        public decimal Shortage { get; set; }

        public decimal QuantityTransferred { get; set; }

        public string? Remarks { get; set; }

        public virtual RetailStation? Station { get; set; }
    }
}
