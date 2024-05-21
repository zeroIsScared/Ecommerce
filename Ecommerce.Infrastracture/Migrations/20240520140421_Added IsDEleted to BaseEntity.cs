using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDEletedtoBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Utilities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserFavorites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyUtilities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyPhoto",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Localities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Currencies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 373, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 387, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 387, DateTimeKind.Unspecified).AddTicks(6173), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(3827), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4025), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4039), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4040), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4042), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4044), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4046), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4055), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4061), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4065), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4069), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4072), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 388, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3239), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3508), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3512), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3522), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3525), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3528), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3529), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3536), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3538), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3541), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3542), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3544), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3546), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3549), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3551), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3554), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3555), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3570), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3572), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3573), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3576), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3577), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3580), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3584), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3586), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3595), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3598), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3599), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3601), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3602), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3606), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3626), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3635), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3636), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3650), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7094), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7098), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7099), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7102), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7177), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7179), new TimeSpan(0, 3, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 17, 4, 21, 389, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 3, 0, 0, 0)), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Utilities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserFavorites");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyUtilities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyPhoto");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Localities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 556, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 557, DateTimeKind.Unspecified).AddTicks(9481), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 557, DateTimeKind.Unspecified).AddTicks(9621), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7238), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7249), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7251), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7275), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7278), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7279), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7282), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7283), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7288), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 558, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7205), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7487), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7523), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7525), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7529), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7545), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7546), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7552), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7567), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7574), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7576), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7583), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7585), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7586), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7595), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7597), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7598), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7611), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7616), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7632), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7635), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7638), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7639), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7642), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7646), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7672), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7685), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 559, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(585), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(969), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(978), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(981), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 5, 20, 10, 21, 20, 560, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
