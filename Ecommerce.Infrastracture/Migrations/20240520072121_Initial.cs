using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForAppartment = table.Column<bool>(type: "bit", nullable: false),
                    ForLand = table.Column<bool>(type: "bit", nullable: false),
                    ForHouse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Localities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localities_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    LocalityId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Localities_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Localities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivingArea = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    RoomNumber = table.Column<int>(type: "int", maxLength: 2, nullable: true),
                    FloorsNumber = table.Column<int>(type: "int", maxLength: 2, nullable: true),
                    State = table.Column<int>(type: "int", nullable: true),
                    AuthorType = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    BuildingType = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    ParkingType = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    LandType = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyDetails_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyPhoto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyPhoto_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyUtilities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    UtilityId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyUtilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyUtilities_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertyUtilities_Utilities_UtilityId",
                        column: x => x.UtilityId,
                        principalTable: "Utilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFavorites",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "Symbol" },
                values: new object[,]
                {
                    { 1L, "MDL", new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 556, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 3, 0, 0, 0)), "Admin", null },
                    { 2L, "EUR", new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 557, DateTimeKind.Unspecified).AddTicks(9481), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "€" },
                    { 3L, "USD", new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 557, DateTimeKind.Unspecified).AddTicks(9621), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "$" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Mun. Chișinău" },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Mun. Bălți" },
                    { 3L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Mun. Bender" },
                    { 4L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7238), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Anenii Noi" },
                    { 5L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Basarabeasca" },
                    { 6L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Briceni" },
                    { 7L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Cahul" },
                    { 8L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7249), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Camenca" },
                    { 9L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7251), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Călărași" },
                    { 10L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Cantemir" },
                    { 11L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Căușeni" },
                    { 12L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Cimișlia" },
                    { 13L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Criuleni" },
                    { 14L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Dondușeni" },
                    { 15L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Drochia" },
                    { 16L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Dubăsari" },
                    { 17L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Edineț" },
                    { 18L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Fălești" },
                    { 19L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Florești" },
                    { 20L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Glodeni" },
                    { 21L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Hîncești" },
                    { 22L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Ialoveni" },
                    { 23L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Leova" },
                    { 24L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Nisporeni" },
                    { 25L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7275), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Ocnița" },
                    { 26L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Orhei" },
                    { 27L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7278), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Rezina" },
                    { 28L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7279), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Rîșcani" },
                    { 29L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Sîngerei" },
                    { 30L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7282), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Soroca" },
                    { 31L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7283), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Strășeni" },
                    { 32L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Șoldănești" },
                    { 33L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Ștefan Vodă" },
                    { 34L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7288), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Taraclia" },
                    { 35L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Telenești" },
                    { 36L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 3, 0, 0, 0)), "Admin", "Ungheni" }
                });

            migrationBuilder.InsertData(
                table: "Utilities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ForAppartment", "ForHouse", "ForLand", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(585), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Ready for entry" },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Furnished" },
                    { 3L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Air conditioning" },
                    { 4L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(969), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Internet" },
                    { 5L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Video surveillance" },
                    { 6L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Autonomous heating" },
                    { 7L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, "Double-glazed windows" },
                    { 8L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, false, "Sauna" },
                    { 9L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(978), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, false, "Swimming pool" },
                    { 10L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, false, false, "Elevator" },
                    { 11L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(981), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, "Gas" },
                    { 12L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, "Electricity" },
                    { 13L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, "Water" },
                    { 14L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, "Sewerage" },
                    { 15L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, "Asphalt road" }
                });

            migrationBuilder.InsertData(
                table: "Localities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DistrictId", "Name", "Region" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7205), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Băcioi", null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Bîc", null },
                    { 3L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7487), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Brăila", null },
                    { 4L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Bubuieci", null },
                    { 5L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Budești", null },
                    { 6L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Buneți", null },
                    { 7L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7523), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Ceroborta", null },
                    { 8L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7525), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Cheltuitori", null },
                    { 9L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Chișinău", null },
                    { 10L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7529), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Ciorescu", null },
                    { 11L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Codru", null },
                    { 12L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Colonița", null },
                    { 13L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Condrița", null },
                    { 14L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Cricova", null },
                    { 15L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Cruzești", null },
                    { 16L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7545), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Dobrogea", null },
                    { 17L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7546), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Dumbrava", null },
                    { 18L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Durlești", null },
                    { 19L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Făurești", null },
                    { 20L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7552), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Frumușica", null },
                    { 21L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Ghidighici", null },
                    { 22L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Goian", null },
                    { 23L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Goianul Nou", null },
                    { 24L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Grătiești", null },
                    { 25L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Hulboaca", null },
                    { 26L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Humulești", null },
                    { 27L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Revaca", null },
                    { 28L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Stăuceni", null },
                    { 29L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Străisteni", null },
                    { 30L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7567), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Sîngera", null },
                    { 31L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Tohatin", null },
                    { 32L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Trușeni", null },
                    { 33L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Vadul lui Vodă", null },
                    { 34L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7574), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Vatra", null },
                    { 35L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7576), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, "Văduleni", null },
                    { 36L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, "Bălți", null },
                    { 37L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, "Elizaveta", null },
                    { 38L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, "Sadovoe", null },
                    { 39L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 3L, "Bender", null },
                    { 40L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7583), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 3L, "Proteagailovca", null },
                    { 41L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7585), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Albinița", null },
                    { 42L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7586), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Anenii Noi", null },
                    { 43L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Balmaz", null },
                    { 44L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7595), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Batîc", null },
                    { 45L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7597), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Beriozchi", null },
                    { 46L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7598), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Botnărești", null },
                    { 47L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Botnăreștii Noi", null },
                    { 48L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Bulboaca", null },
                    { 49L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Calfa", null },
                    { 50L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Calfa Nouă", null },
                    { 51L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Chetrosu", null },
                    { 52L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Chirca", null },
                    { 53L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Ciobanovca", null },
                    { 54L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7611), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Cobusca Nouă", null },
                    { 55L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Cobusca Veche", null },
                    { 56L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7616), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Crețoaia", null },
                    { 57L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Delacău", null },
                    { 58L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Floreni", null },
                    { 59L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Florești", null },
                    { 60L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7632), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Geamăna", null },
                    { 61L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Gura Bîcului", null },
                    { 62L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7635), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Hîrbovăț", null },
                    { 63L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Hîrbovățul Nou", null },
                    { 64L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7638), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Larga", null },
                    { 65L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7639), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Maximovca", null },
                    { 66L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7642), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Mereni", null },
                    { 67L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Merenii Noi", null },
                    { 68L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Mirnoe", null },
                    { 69L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7646), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Nicolaevca", null },
                    { 70L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Ochiul Roș", null },
                    { 71L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Picus", null },
                    { 72L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Puhăceni", null },
                    { 73L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7672), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Roșcani", null },
                    { 74L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Ruseni", null },
                    { 75L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Salcia", null },
                    { 76L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Socoleni", null },
                    { 77L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Speia", null },
                    { 78L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Șerpeni", null },
                    { 79L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Telița", null },
                    { 80L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Telița Nouă", null },
                    { 81L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7685), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Todirești", null },
                    { 82L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Troița Nouă", null },
                    { 83L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Țînțăreni", null },
                    { 84L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Varnița", null },
                    { 85L, new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, "Zolotievca", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_LocalityId",
                table: "Addresses",
                column: "LocalityId");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Localities_DistrictId",
                table: "Localities",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AddressId",
                table: "Properties",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CurrencyId",
                table: "Properties",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                table: "Properties",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_PropertyId",
                table: "PropertyDetails",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyPhoto_PropertyId",
                table: "PropertyPhoto",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyUtilities_PropertyId",
                table: "PropertyUtilities",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyUtilities_UtilityId",
                table: "PropertyUtilities",
                column: "UtilityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_PropertyId",
                table: "UserFavorites",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_UserId",
                table: "UserFavorites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "PropertyPhoto");

            migrationBuilder.DropTable(
                name: "PropertyUtilities");

            migrationBuilder.DropTable(
                name: "UserFavorites");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Utilities");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Localities");

            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}
