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
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilities", x => x.Id);
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "IsDeleted", "Symbol" },
                values: new object[,]
                {
                    { 1L, "MDL", new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 800, DateTimeKind.Unspecified).AddTicks(841), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, null },
                    { 2L, "EUR", new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 801, DateTimeKind.Unspecified).AddTicks(5787), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "€" },
                    { 3L, "USD", new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 801, DateTimeKind.Unspecified).AddTicks(5924), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "$" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Mun. Chișinău" },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3176), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Mun. Bălți" },
                    { 3L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Mun. Bender" },
                    { 4L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Anenii Noi" },
                    { 5L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Basarabeasca" },
                    { 6L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Briceni" },
                    { 7L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3215), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Cahul" },
                    { 8L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Camenca" },
                    { 9L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3218), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Călărași" },
                    { 10L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Cantemir" },
                    { 11L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3222), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Căușeni" },
                    { 12L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3223), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Cimișlia" },
                    { 13L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Criuleni" },
                    { 14L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Dondușeni" },
                    { 15L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3227), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Drochia" },
                    { 16L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3229), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Dubăsari" },
                    { 17L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3230), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Edineț" },
                    { 18L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3232), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Fălești" },
                    { 19L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3233), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Florești" },
                    { 20L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Glodeni" },
                    { 21L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3236), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Hîncești" },
                    { 22L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ialoveni" },
                    { 23L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3239), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Leova" },
                    { 24L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3240), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Nisporeni" },
                    { 25L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3241), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ocnița" },
                    { 26L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Orhei" },
                    { 27L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3244), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Rezina" },
                    { 28L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3245), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Rîșcani" },
                    { 29L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Sîngerei" },
                    { 30L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Soroca" },
                    { 31L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3249), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Strășeni" },
                    { 32L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Șoldănești" },
                    { 33L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ștefan Vodă" },
                    { 34L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Taraclia" },
                    { 35L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3255), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Telenești" },
                    { 36L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 802, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ungheni" }
                });

            migrationBuilder.InsertData(
                table: "Utilities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ForAppartment", "ForHouse", "ForLand", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Ready for entry" },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Furnished" },
                    { 3L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5891), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Air conditioning" },
                    { 4L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Internet" },
                    { 5L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5895), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Video surveillance" },
                    { 6L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5898), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Autonomous heating" },
                    { 7L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5900), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Double-glazed windows" },
                    { 8L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5901), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, false, false, "Sauna" },
                    { 9L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5903), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, false, false, "Swimming pool" },
                    { 10L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5905), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, false, false, false, "Elevator" },
                    { 11L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5906), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Gas" },
                    { 12L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5982), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Electricity" },
                    { 13L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Water" },
                    { 14L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5986), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Sewerage" },
                    { 15L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(5988), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Asphalt road" }
                });

            migrationBuilder.InsertData(
                table: "Localities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DistrictId", "IsDeleted", "Name", "Region" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2218), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Băcioi", null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2469), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Bîc", null },
                    { 3L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2472), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Brăila", null },
                    { 4L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Bubuieci", null },
                    { 5L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Budești", null },
                    { 6L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Buneți", null },
                    { 7L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2479), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Ceroborta", null },
                    { 8L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Cheltuitori", null },
                    { 9L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2482), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Chișinău", null },
                    { 10L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Ciorescu", null },
                    { 11L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Codru", null },
                    { 12L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Colonița", null },
                    { 13L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2489), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Condrița", null },
                    { 14L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2490), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Cricova", null },
                    { 15L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Cruzești", null },
                    { 16L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Dobrogea", null },
                    { 17L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2494), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Dumbrava", null },
                    { 18L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Durlești", null },
                    { 19L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Făurești", null },
                    { 20L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2505), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Frumușica", null },
                    { 21L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Ghidighici", null },
                    { 22L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Goian", null },
                    { 23L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Goianul Nou", null },
                    { 24L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2511), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Grătiești", null },
                    { 25L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Hulboaca", null },
                    { 26L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Humulești", null },
                    { 27L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Revaca", null },
                    { 28L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Stăuceni", null },
                    { 29L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Străisteni", null },
                    { 30L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2519), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Sîngera", null },
                    { 31L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Tohatin", null },
                    { 32L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Trușeni", null },
                    { 33L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2545), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Vadul lui Vodă", null },
                    { 34L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Vatra", null },
                    { 35L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Văduleni", null },
                    { 36L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, false, "Bălți", null },
                    { 37L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, false, "Elizaveta", null },
                    { 38L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2553), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, false, "Sadovoe", null },
                    { 39L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2554), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 3L, false, "Bender", null },
                    { 40L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2555), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 3L, false, "Proteagailovca", null },
                    { 41L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Albinița", null },
                    { 42L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Anenii Noi", null },
                    { 43L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Balmaz", null },
                    { 44L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2561), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Batîc", null },
                    { 45L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2562), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Beriozchi", null },
                    { 46L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2564), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Botnărești", null },
                    { 47L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Botnăreștii Noi", null },
                    { 48L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Bulboaca", null },
                    { 49L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Calfa", null },
                    { 50L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Calfa Nouă", null },
                    { 51L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Chetrosu", null },
                    { 52L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Chirca", null },
                    { 53L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Ciobanovca", null },
                    { 54L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Cobusca Nouă", null },
                    { 55L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2582), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Cobusca Veche", null },
                    { 56L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Crețoaia", null },
                    { 57L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Delacău", null },
                    { 58L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Floreni", null },
                    { 59L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2588), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Florești", null },
                    { 60L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Geamăna", null },
                    { 61L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Gura Bîcului", null },
                    { 62L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Hîrbovăț", null },
                    { 63L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Hîrbovățul Nou", null },
                    { 64L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Larga", null },
                    { 65L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Maximovca", null },
                    { 66L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2598), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Mereni", null },
                    { 67L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Merenii Noi", null },
                    { 68L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Mirnoe", null },
                    { 69L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Nicolaevca", null },
                    { 70L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Ochiul Roș", null },
                    { 71L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Picus", null },
                    { 72L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2606), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Puhăceni", null },
                    { 73L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Roșcani", null },
                    { 74L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2609), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Ruseni", null },
                    { 75L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Salcia", null },
                    { 76L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Socoleni", null },
                    { 77L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Speia", null },
                    { 78L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Șerpeni", null },
                    { 79L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Telița", null },
                    { 80L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Telița Nouă", null },
                    { 81L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Todirești", null },
                    { 82L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2620), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Troița Nouă", null },
                    { 83L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Țînțăreni", null },
                    { 84L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2623), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Varnița", null },
                    { 85L, new DateTimeOffset(new DateTime(2024, 5, 23, 5, 28, 19, 803, DateTimeKind.Unspecified).AddTicks(2624), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Zolotievca", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_LocalityId",
                table: "Addresses",
                column: "LocalityId");

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
                name: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "PropertyPhoto");

            migrationBuilder.DropTable(
                name: "PropertyUtilities");

            migrationBuilder.DropTable(
                name: "UserFavorites");

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
