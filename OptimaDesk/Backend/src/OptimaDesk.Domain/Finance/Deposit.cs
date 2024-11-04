using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    /// <summary>
    /// Represents deposits made by a retail station.
    /// </summary>
    public class Deposit : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public string? BankName { get; set; }

        [Required]
        public string? ReferenceNo { get; set; }

        [Required]
        public PaymentType PaymentType { get; set; }

        public decimal Amount { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}