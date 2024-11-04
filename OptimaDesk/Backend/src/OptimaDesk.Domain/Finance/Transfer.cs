using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    public class Transfer : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string? CustomerName { get; set; }
        public string? CustomerBank { get; set; }
        public string? RecepientBank { get; set; }
        public decimal LitreDispensed { get; set; }
        public decimal Amount { get; set; }
        public string? ConfirmedBy { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
