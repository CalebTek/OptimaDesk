using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    /// <summary>
    /// Represents generator usage records for a retail station.
    /// </summary>
    public class GeneratorUsage : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public ProductType ProductType { get; set; }
        public string? PumpNo { get; set; }
        public decimal MeterBeforeDispensed { get; set; }
        public decimal MeterAfterDispensed { get; set; }
        public decimal? LitreDispensed { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
