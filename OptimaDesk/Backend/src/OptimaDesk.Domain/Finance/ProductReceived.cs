using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    public class ProductReceived : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public ProductType ProductType { get; set; }
        public decimal StockBeforeIssued { get; set; }
        public decimal TankIssued { get; set; }
        public decimal LitreIssued { get; set; }
        public string? TransporterName { get; set; }
        public string? TruckNo { get; set; }
        public string? WaybillNo { get; set; }
        public string? LoadingTicket { get; set; }
        public string? DriverName { get; set; }
        public ProductMovementType ProductMovementType { get; set; }
        public string? StationName { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
