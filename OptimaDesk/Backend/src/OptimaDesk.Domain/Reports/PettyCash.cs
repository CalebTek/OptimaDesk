using OptimaDesk.Common.Models;
using OptimaDesk.Domain.Finance;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Reports
{
    /// <summary>
    /// Represents petty cash records for a retail station.
    /// </summary>
    public class PettyCash : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        public virtual ICollection<ExpenseControl>? Expenses { get; set; }

        public decimal? TotalCashDr { get; set; }

        public decimal? TotalCashCr { get; set; }

        public decimal? Balance { get; set; }

        public virtual RetailStation? Station { get; set; }
    }
}
