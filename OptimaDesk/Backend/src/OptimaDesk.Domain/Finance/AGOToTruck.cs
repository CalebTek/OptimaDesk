using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    /// <summary>
    /// Represents the transfer of AGO to a truck.
    /// </summary>
    public class AGOToTruck : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Transporter Transporter { get; set; }
        public string? TransporterName { get; set; }
        public string? TruckNo { get; set; }
        public string? DriverName { get; set; }
        public string? DAFSerialNo { get; set; }
        public string? LitreIssued { get; set; }
        public string? ApprovedBy { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
