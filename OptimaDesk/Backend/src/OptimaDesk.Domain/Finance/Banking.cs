using OptimaDesk.Common.Models;
using OptimaDesk.Domain.RetailStations;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Finance
{
    /// <summary>
    /// Represents banking operations at a retail station.
    /// </summary>
    public class Banking : BaseEntity
    {
        [Required]
        public string? RetailStationId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Collections of POS and Deposits
        public virtual ICollection<POS> POS { get; set; } = new List<POS>();
        public virtual ICollection<Deposit> Deposits { get; set; } = new List<Deposit>();

        public decimal TotalPOS { get; set; }
        public decimal TotalDeposits { get; set; }

        // Navigation property
        public virtual RetailStation? Station { get; set; }
    }
}
