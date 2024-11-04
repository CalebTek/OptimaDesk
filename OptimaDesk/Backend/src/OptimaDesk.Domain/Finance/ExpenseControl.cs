using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    public class ExpenseControl : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public decimal OpeningPettyCash { get; set; }
        public decimal Reimbursement { get; set; }
        public decimal TotalCashAtHand { get; set; }

        // Collection of Expenses
        public virtual ICollection<Expense> Expense { get; set; } = new List<Expense>();
        public decimal? TotalDisbursed { get; set; }
        public decimal? TheoreticalClosingPettyCash { get; set; }
        public decimal? ActualClosingPettyCash { get; set; }
        public decimal? CashDifference { get; set; }
        public string? Description { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
