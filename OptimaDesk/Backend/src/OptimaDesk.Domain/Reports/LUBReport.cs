using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using OptimaDesk.Domain.Sales;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Reports
{
    /// <summary>
    /// Represents the lubricating oil report for a retail station.
    /// </summary>
    public class LUBReport : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        public virtual ICollection<LUBTank>? Tanks { get; set; }

        public virtual ICollection<LUBSales>?Sales { get; set; }

        public string? Comments { get; set; }

        public virtual RetailStation? Station { get; set; }
    }
}
