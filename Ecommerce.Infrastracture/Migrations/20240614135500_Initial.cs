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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1L, "MDL", new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 21, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, null },
                    { 2L, "EUR", new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "€" },
                    { 3L, "USD", new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "$" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Mun. Chișinău" },
                    { 2L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Mun. Bălți" },
                    { 3L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Mun. Bender" },
                    { 4L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Anenii Noi" },
                    { 5L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Basarabeasca" },
                    { 6L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Briceni" },
                    { 7L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Cahul" },
                    { 8L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Camenca" },
                    { 9L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Călărași" },
                    { 10L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Cantemir" },
                    { 11L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Căușeni" },
                    { 12L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Cimișlia" },
                    { 13L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Criuleni" },
                    { 14L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Dondușeni" },
                    { 15L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7701), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Drochia" },
                    { 16L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Dubăsari" },
                    { 17L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Edineț" },
                    { 18L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7706), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Fălești" },
                    { 19L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Florești" },
                    { 20L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7709), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Glodeni" },
                    { 21L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Hîncești" },
                    { 22L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7711), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ialoveni" },
                    { 23L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7713), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Leova" },
                    { 24L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Nisporeni" },
                    { 25L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ocnița" },
                    { 26L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Orhei" },
                    { 27L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Rezina" },
                    { 28L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7747), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Rîșcani" },
                    { 29L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Sîngerei" },
                    { 30L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Soroca" },
                    { 31L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7751), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Strășeni" },
                    { 32L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Șoldănești" },
                    { 33L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7754), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ștefan Vodă" },
                    { 34L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7756), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Taraclia" },
                    { 35L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7757), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Telenești" },
                    { 36L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7759), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, "Ungheni" }
                });

            migrationBuilder.InsertData(
                table: "Utilities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ForAppartment", "ForHouse", "ForLand", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(57), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Ready for entry" },
                    { 2L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Furnished" },
                    { 3L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(425), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Air conditioning" },
                    { 4L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Internet" },
                    { 5L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Video surveillance" },
                    { 6L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Autonomous heating" },
                    { 7L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(434), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, true, false, false, "Double-glazed windows" },
                    { 8L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(435), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, false, false, "Sauna" },
                    { 9L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(437), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, false, false, "Swimming pool" },
                    { 10L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(469), new TimeSpan(0, 3, 0, 0, 0)), "Admin", true, false, false, false, "Elevator" },
                    { 11L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Gas" },
                    { 12L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Electricity" },
                    { 13L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(556), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Water" },
                    { 14L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(558), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Sewerage" },
                    { 15L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(559), new TimeSpan(0, 3, 0, 0, 0)), "Admin", false, true, true, false, "Asphalt road" }
                });

            migrationBuilder.InsertData(
                table: "Localities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DistrictId", "IsDeleted", "Name", "Region" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Băcioi", null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Bîc", null },
                    { 3L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Brăila", null },
                    { 4L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Bubuieci", null },
                    { 5L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Budești", null },
                    { 6L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Buneți", null },
                    { 7L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6680), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Ceroborta", null },
                    { 8L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Cheltuitori", null },
                    { 9L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6683), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Chișinău", null },
                    { 10L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6685), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Ciorescu", null },
                    { 11L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Codru", null },
                    { 12L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Colonița", null },
                    { 13L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6689), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Condrița", null },
                    { 14L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6690), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Cricova", null },
                    { 15L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6692), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Cruzești", null },
                    { 16L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6693), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Dobrogea", null },
                    { 17L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Dumbrava", null },
                    { 18L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Durlești", null },
                    { 19L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Făurești", null },
                    { 20L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Frumușica", null },
                    { 21L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Ghidighici", null },
                    { 22L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6702), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Goian", null },
                    { 23L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Goianul Nou", null },
                    { 24L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6705), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Grătiești", null },
                    { 25L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Hulboaca", null },
                    { 26L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Humulești", null },
                    { 27L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6709), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Revaca", null },
                    { 28L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6710), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Stăuceni", null },
                    { 29L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6712), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Străisteni", null },
                    { 30L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Sîngera", null },
                    { 31L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6714), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Tohatin", null },
                    { 32L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Trușeni", null },
                    { 33L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Vadul lui Vodă", null },
                    { 34L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Vatra", null },
                    { 35L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 1L, false, "Văduleni", null },
                    { 36L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, false, "Bălți", null },
                    { 37L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, false, "Elizaveta", null },
                    { 38L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 2L, false, "Sadovoe", null },
                    { 39L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6732), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 3L, false, "Bender", null },
                    { 40L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 3L, false, "Proteagailovca", null },
                    { 41L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6735), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Albinița", null },
                    { 42L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Anenii Noi", null },
                    { 43L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Balmaz", null },
                    { 44L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Batîc", null },
                    { 45L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Beriozchi", null },
                    { 46L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Botnărești", null },
                    { 47L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Botnăreștii Noi", null },
                    { 48L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Bulboaca", null },
                    { 49L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6767), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Calfa", null },
                    { 50L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6769), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Calfa Nouă", null },
                    { 51L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Chetrosu", null },
                    { 52L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Chirca", null },
                    { 53L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Ciobanovca", null },
                    { 54L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Cobusca Nouă", null },
                    { 55L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6776), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Cobusca Veche", null },
                    { 56L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6777), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Crețoaia", null },
                    { 57L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Delacău", null },
                    { 58L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Floreni", null },
                    { 59L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6781), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Florești", null },
                    { 60L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6783), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Geamăna", null },
                    { 61L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Gura Bîcului", null },
                    { 62L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6785), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Hîrbovăț", null },
                    { 63L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6787), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Hîrbovățul Nou", null },
                    { 64L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Larga", null },
                    { 65L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Maximovca", null },
                    { 66L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6792), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Mereni", null },
                    { 67L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Merenii Noi", null },
                    { 68L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Mirnoe", null },
                    { 69L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Nicolaevca", null },
                    { 70L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Ochiul Roș", null },
                    { 71L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6799), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Picus", null },
                    { 72L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Puhăceni", null },
                    { 73L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Roșcani", null },
                    { 74L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6803), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Ruseni", null },
                    { 75L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Salcia", null },
                    { 76L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Socoleni", null },
                    { 77L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Speia", null },
                    { 78L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Șerpeni", null },
                    { 79L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Telița", null },
                    { 80L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Telița Nouă", null },
                    { 81L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Todirești", null },
                    { 82L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Troița Nouă", null },
                    { 83L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Țînțăreni", null },
                    { 84L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Varnița", null },
                    { 85L, new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 3, 0, 0, 0)), "Admin", 4L, false, "Zolotievca", null }
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
