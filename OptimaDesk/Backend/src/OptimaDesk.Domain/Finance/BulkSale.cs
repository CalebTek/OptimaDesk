using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    public class BulkSale : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public ProductType ProductType { get; set; }
        public string? TankNo { get; set; }
        public decimal StockBeforeDispensed { get; set; }
        public decimal StockAfterDispensed { get; set; }
        public decimal? LitreDispensed { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerLocation { get; set; }
        public string? ApprovedBy { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
