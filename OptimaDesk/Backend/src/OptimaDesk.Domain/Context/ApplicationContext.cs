using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OptimaDesk.Common.Models;
using OptimaDesk.Domain.Finance;
using OptimaDesk.Domain.Reports;
using OptimaDesk.Domain.RetailStations;
using OptimaDesk.Domain.Sales;
using OptimaDesk.Domain.Stock;
using OptimaDesk.Domain.Users;
using System.Reflection;
using System.Reflection.Emit;

namespace OptimaDesk.Domain.Context
{
    public class ApplicationContext : IdentityDbContext<AppUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> getData) : base(getData)
        {
        }

        public DbSet<ProductTracker> ProductTrackers { get; set; }
        public DbSet<InventorySummary> InventorySummaries { get; set; }
        public DbSet<BankingReconciliation> BankingReconciliations { get; set; }
        public DbSet<PettyCash> PettyCashes { get; set; }
        public DbSet<LUBReport> LUBReports { get; set; }
        public DbSet<AGOToTruck> AGOToTrucks { get; set; }
        public DbSet<GeneratorUsage> GeneratorUsages { get; set; }
        public DbSet<BulkSale> BulkSales { get; set; }
        public DbSet<FinancialReconciliation> FinancialReconciliations { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<FinancialAsset> FinancialAssets { get; set; }
        public DbSet<ProductReceived> ProductsReceived { get; set; }
        public DbSet<ExpenseControl> ExpenseControls { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<LUBTank> LUBTanks { get; set; }
        public DbSet<LUBSales> LUBSales { get; set; }
        public DbSet<Banking> Bankings { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<POS> PointOfSales { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<RetailStation> RetailStations { get; set; }
        public DbSet<UGTank> UGTanks { get; set; }
        public DbSet<PumpSales> PumpSales { get; set; }
        public DbSet<StockPosition> StockPositions { get; set; }
        public DbSet<StockReconciliation> StockReconciliations { get; set; }
        public DbSet<StationManager> StationManagers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>())
            {
                    switch (item.State)
                {
                    case EntityState.Modified:
                        item.Entity.UpdatedAt = DateTime.UtcNow;
                        break;
                    case EntityState.Added:
                        item.Entity.Id = Guid.NewGuid().ToString();
                        item.Entity.CreatedAt = DateTime.UtcNow;
                        break;
                    default:
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(),
                (type) => !string.IsNullOrEmpty(type.Namespace) && !type.IsInterface &&
                          type is { IsAbstract: false, BaseType: not null } &&
                          typeof(IEntityTypeConfiguration<>).IsAssignableFrom(type));

            foreach (var property in builder.Model.GetEntityTypes()
                         .SelectMany(t => t.GetProperties())
                         .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,2)");
            }

            // String Properties
            foreach (var property in builder.Model.GetEntityTypes()
             .SelectMany(t => t.GetProperties())
             .Where(p => p.ClrType == typeof(string)))
            {
                property.SetMaxLength(255);
            }

            builder.Entity<AppUser>()
                .HasIndex(t => t.Email)
                .IsUnique();

            builder.Entity<AppUser>()
                .HasIndex(t => t.PhoneNumber)
                .IsUnique();

            //builder.Entity<Pump>()
            //     .HasOne(p => p.PumpSales)
            //     .WithMany(ps => ps.PMSPumps)
            //     .HasForeignKey(p => p.PumpSalesId)
            //     .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Pump>()
            //    .HasOne(p => p.PumpSales)
            //    .WithMany(ps => ps.AGOPumps)
            //    .HasForeignKey(p => p.PumpSalesId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<UGTank>()
            //    .HasOne(u => u.StockPosition)
            //    .WithMany(sp => sp.PMSTanks)
            //    .HasForeignKey(u => u.StockPositionId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<UGTank>()
            //    .HasOne(u => u.StockPosition)
            //    .WithMany(sp => sp.AGOTanks)
            //    .HasForeignKey(u => u.StockPositionId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<LUBTank>()
            //    .HasOne(u => u.StockPosition)
            //    .WithMany(sp => sp.LUBTanks)
            //    .HasForeignKey(u => u.StockPositionId)
            //    .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}
