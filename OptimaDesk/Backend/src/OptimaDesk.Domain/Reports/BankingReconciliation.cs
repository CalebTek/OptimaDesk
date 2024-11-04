using OptimaDesk.Common.Models;
using OptimaDesk.Domain.Finance;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Reports
{
    /// <summary>
    /// Represents banking reconciliation details for a retail station.
    /// </summary>
    public class BankingReconciliation : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        public virtual ICollection<Banking>? Banks { get; set; }

        public virtual ICollection<Transfer>? Transfers { get; set; }

        public virtual ICollection<FinancialAsset>? FinancialAssets { get; set; }

        public virtual RetailStation? Station { get; set; }
    }
}
