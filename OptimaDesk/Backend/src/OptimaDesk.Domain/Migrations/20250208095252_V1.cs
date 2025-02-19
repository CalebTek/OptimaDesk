using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OptimaDesk.Domain.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Otp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OtpExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RetailStations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NoOfAGO = table.Column<int>(type: "int", nullable: false),
                    NoOfPMS = table.Column<int>(type: "int", nullable: false),
                    LUBCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalNoOfTanks = table.Column<int>(type: "int", nullable: false),
                    TankCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentPMS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentAGO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentLUB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailStations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGOToTrucks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Transporter = table.Column<int>(type: "int", nullable: false),
                    TransporterName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TruckNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DAFSerialNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LitreIssued = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGOToTrucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AGOToTrucks_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankingReconciliations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankingReconciliations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankingReconciliations_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BulkSales",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    TankNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StockBeforeDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockAfterDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LitreDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CustomerLocation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BulkSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BulkSales_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinancialReconciliations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CashBF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSSold = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOSold = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LubricantSold = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BulkSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    POS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAtHand = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOToTruck = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOToThirdPartyTruck = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Transfer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GeneratorUsage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClosingCash = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashDifference = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialReconciliations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialReconciliations_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneratorUsages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    PumpNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MeterBeforeDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MeterAfterDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LitreDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratorUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneratorUsages_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventorySummaries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PMSClosingStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOClosingStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBClosingStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSPumpSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOPumpSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LUBSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PMSGenUsage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOGenUsage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOToTruck = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrepaidSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPMSSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAGOSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PMSPriceChange = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOPriceChange = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LUBPriceChange = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorySummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventorySummaries_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LUBReports",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUBReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LUBReports_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PettyCashes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TotalCashDr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalCashCr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PettyCashes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PettyCashes_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsReceived",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    StockBeforeIssued = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TankIssued = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LitreIssued = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransporterName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TruckNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WaybillNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoadingTicket = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProductMovementType = table.Column<int>(type: "int", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsReceived", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsReceived_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTrackers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LoadingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaybillNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StationLocation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoadingTicketNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Transporter = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TruckNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Product = table.Column<int>(type: "int", nullable: false),
                    QuantityReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Shortage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityTransferred = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTrackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTrackers_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PumpSales",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PMSTotalRTT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PMSTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PMSTotalActualSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOTotalRTT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOTotalActualSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PMSPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSSalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AGOSalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PumpSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PumpSales_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StationManagers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StationManagers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationManagers_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockPositions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PMSTotalOpeningVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSTotalClosingVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSTotalProductReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSTotalTankSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOTotalOpeningVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOTotalClosingVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOTotalProductReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOTotalTankSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBTotalOpeningVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBTotalClosingVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBTotalProductReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBTotalTankSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockPositions_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockReconciliations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PMSPumpSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOPumpSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMSUGTankSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGOUGTankSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBPACKSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReconciliations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockReconciliations_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bankings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPOS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDeposits = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankingReconciliationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bankings_BankingReconciliations_BankingReconciliationId",
                        column: x => x.BankingReconciliationId,
                        principalTable: "BankingReconciliations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bankings_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinancialAssets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssetType = table.Column<int>(type: "int", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LitreDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BankingReconciliationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialAssets_BankingReconciliations_BankingReconciliationId",
                        column: x => x.BankingReconciliationId,
                        principalTable: "BankingReconciliations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinancialAssets_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CustomerBank = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RecepientBank = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LitreDispensed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfirmedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BankingReconciliationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_BankingReconciliations_BankingReconciliationId",
                        column: x => x.BankingReconciliationId,
                        principalTable: "BankingReconciliations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transfers_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LUBSales",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpeningStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClosingStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LUBReportId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUBSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LUBSales_LUBReports_LUBReportId",
                        column: x => x.LUBReportId,
                        principalTable: "LUBReports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LUBSales_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseControls",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpeningPettyCash = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reimbursement = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCashAtHand = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDisbursed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TheoreticalClosingPettyCash = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActualClosingPettyCash = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CashDifference = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PettyCashId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseControls_PettyCashes_PettyCashId",
                        column: x => x.PettyCashId,
                        principalTable: "PettyCashes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExpenseControls_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pumps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    OpeningMeter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClosingMeter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RTT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PumpSalesId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PumpSalesId1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pumps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pumps_PumpSales_PumpSalesId",
                        column: x => x.PumpSalesId,
                        principalTable: "PumpSales",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pumps_PumpSales_PumpSalesId1",
                        column: x => x.PumpSalesId1,
                        principalTable: "PumpSales",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pumps_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LUBTanks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TankCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OpeningVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClosingVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OpeningDip = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClosingDip = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityTransferred = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LUBReportId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StockPositionId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUBTanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LUBTanks_LUBReports_LUBReportId",
                        column: x => x.LUBReportId,
                        principalTable: "LUBReports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LUBTanks_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LUBTanks_StockPositions_StockPositionId",
                        column: x => x.StockPositionId,
                        principalTable: "StockPositions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UGTanks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OpeningStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClosingStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockPositionId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StockPositionId1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UGTanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UGTanks_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UGTanks_StockPositions_StockPositionId",
                        column: x => x.StockPositionId,
                        principalTable: "StockPositions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UGTanks_StockPositions_StockPositionId1",
                        column: x => x.StockPositionId1,
                        principalTable: "StockPositions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankingId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposits_Bankings_BankingId",
                        column: x => x.BankingId,
                        principalTable: "Bankings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deposits_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointOfSales",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RetailStationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TerminalId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TerminalSerialNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EODAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankingId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointOfSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointOfSales_Bankings_BankingId",
                        column: x => x.BankingId,
                        principalTable: "Bankings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PointOfSales_RetailStations_RetailStationId",
                        column: x => x.RetailStationId,
                        principalTable: "RetailStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ExpenseCategory = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExpenseControlId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseControls_ExpenseControlId",
                        column: x => x.ExpenseControlId,
                        principalTable: "ExpenseControls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGOToTrucks_RetailStationId",
                table: "AGOToTrucks",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankingReconciliations_RetailStationId",
                table: "BankingReconciliations",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bankings_BankingReconciliationId",
                table: "Bankings",
                column: "BankingReconciliationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bankings_RetailStationId",
                table: "Bankings",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_BulkSales_RetailStationId",
                table: "BulkSales",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_BankingId",
                table: "Deposits",
                column: "BankingId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_RetailStationId",
                table: "Deposits",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseControls_PettyCashId",
                table: "ExpenseControls",
                column: "PettyCashId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseControls_RetailStationId",
                table: "ExpenseControls",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseControlId",
                table: "Expenses",
                column: "ExpenseControlId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAssets_BankingReconciliationId",
                table: "FinancialAssets",
                column: "BankingReconciliationId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAssets_RetailStationId",
                table: "FinancialAssets",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialReconciliations_RetailStationId",
                table: "FinancialReconciliations",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneratorUsages_RetailStationId",
                table: "GeneratorUsages",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_InventorySummaries_RetailStationId",
                table: "InventorySummaries",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_LUBReports_RetailStationId",
                table: "LUBReports",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_LUBSales_LUBReportId",
                table: "LUBSales",
                column: "LUBReportId");

            migrationBuilder.CreateIndex(
                name: "IX_LUBSales_RetailStationId",
                table: "LUBSales",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_LUBTanks_LUBReportId",
                table: "LUBTanks",
                column: "LUBReportId");

            migrationBuilder.CreateIndex(
                name: "IX_LUBTanks_RetailStationId",
                table: "LUBTanks",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_LUBTanks_StockPositionId",
                table: "LUBTanks",
                column: "StockPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PettyCashes_RetailStationId",
                table: "PettyCashes",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_PointOfSales_BankingId",
                table: "PointOfSales",
                column: "BankingId");

            migrationBuilder.CreateIndex(
                name: "IX_PointOfSales_RetailStationId",
                table: "PointOfSales",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsReceived_RetailStationId",
                table: "ProductsReceived",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTrackers_RetailStationId",
                table: "ProductTrackers",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Pumps_PumpSalesId",
                table: "Pumps",
                column: "PumpSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pumps_PumpSalesId1",
                table: "Pumps",
                column: "PumpSalesId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pumps_RetailStationId",
                table: "Pumps",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_PumpSales_RetailStationId",
                table: "PumpSales",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_StationManagers_AppUserId",
                table: "StationManagers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StationManagers_RetailStationId",
                table: "StationManagers",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_StockPositions_RetailStationId",
                table: "StockPositions",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReconciliations_RetailStationId",
                table: "StockReconciliations",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_BankingReconciliationId",
                table: "Transfers",
                column: "BankingReconciliationId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_RetailStationId",
                table: "Transfers",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_UGTanks_RetailStationId",
                table: "UGTanks",
                column: "RetailStationId");

            migrationBuilder.CreateIndex(
                name: "IX_UGTanks_StockPositionId",
                table: "UGTanks",
                column: "StockPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_UGTanks_StockPositionId1",
                table: "UGTanks",
                column: "StockPositionId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGOToTrucks");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BulkSales");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "FinancialAssets");

            migrationBuilder.DropTable(
                name: "FinancialReconciliations");

            migrationBuilder.DropTable(
                name: "GeneratorUsages");

            migrationBuilder.DropTable(
                name: "InventorySummaries");

            migrationBuilder.DropTable(
                name: "LUBSales");

            migrationBuilder.DropTable(
                name: "LUBTanks");

            migrationBuilder.DropTable(
                name: "PointOfSales");

            migrationBuilder.DropTable(
                name: "ProductsReceived");

            migrationBuilder.DropTable(
                name: "ProductTrackers");

            migrationBuilder.DropTable(
                name: "Pumps");

            migrationBuilder.DropTable(
                name: "StationManagers");

            migrationBuilder.DropTable(
                name: "StockReconciliations");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "UGTanks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ExpenseControls");

            migrationBuilder.DropTable(
                name: "LUBReports");

            migrationBuilder.DropTable(
                name: "Bankings");

            migrationBuilder.DropTable(
                name: "PumpSales");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StockPositions");

            migrationBuilder.DropTable(
                name: "PettyCashes");

            migrationBuilder.DropTable(
                name: "BankingReconciliations");

            migrationBuilder.DropTable(
                name: "RetailStations");
        }
    }
}
