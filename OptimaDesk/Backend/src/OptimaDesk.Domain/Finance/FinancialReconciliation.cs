using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    public class FinancialReconciliation : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public decimal CashBF { get; set; }
        public decimal PMSSold { get; set; }
        public decimal AGOSold { get; set; }
        public decimal LubricantSold { get; set; }
        public decimal BulkSales { get; set; }
        public decimal TotalSales { get; set; }
        public decimal POS { get; set; }
        public decimal CashSales { get; set; }
        public decimal CashAtHand { get; set; }
        public decimal AGOToTruck { get; set; }
        public decimal AGOToThirdPartyTruck { get; set; }
        public decimal Transfer { get; set; }
        public decimal GeneratorUsage { get; set; }
        public decimal Discount { get; set; }
        public decimal ClosingCash { get; set; }
        public decimal? CashDifference { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
