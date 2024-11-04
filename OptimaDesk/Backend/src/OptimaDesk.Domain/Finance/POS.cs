using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    /// <summary>
    /// Represents point of sale transactions at a retail station.
    /// </summary>
    public class POS : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public string? BankName { get; set; }

        [Required]
        public string? TerminalId { get; set; }

        [Required]
        public string? TerminalSerialNumber { get; set; }

        public decimal EODAmount { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}