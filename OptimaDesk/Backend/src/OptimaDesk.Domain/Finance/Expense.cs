using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    public class Expense : BaseEntity
    {
        public ExpenseCategory ExpenseCategory { get; set; }

        [Required]
        public string? Description { get; set; }
        public string? Code { get; set; }
        public decimal Amount { get; set; }
        public string? AttachmentUrl { get; set; }
    }
}