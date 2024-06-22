using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class AddedLongitudeandLatitudecolumnstoAddresstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "ApplicationUsers");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 414, DateTimeKind.Unspecified).AddTicks(253), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 429, DateTimeKind.Unspecified).AddTicks(8222), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 429, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6473), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6648), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6654), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6675), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6732), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6740), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6743), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6749), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6752), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6753), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6760), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 430, DateTimeKind.Unspecified).AddTicks(6762), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7462), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7469), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7479), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7481), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7482), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7487), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7492), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7493), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7509), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7519), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7521), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7523), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7562), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7567), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7573), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7574), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7576), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7586), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7589), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7591), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7592), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7594), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7595), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7597), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7598), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7603), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7609), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7611), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7612), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7616), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7621), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7622), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7624), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 431, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(848), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1161), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1173), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1244), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1247), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1248), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 21, 15, 45, 53, 432, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 21, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7701), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7706), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7709), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7711), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7713), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7747), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7751), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7754), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7756), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7757), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 23, DateTimeKind.Unspecified).AddTicks(7759), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6683), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6685), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6689), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6690), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6692), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6693), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6702), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6705), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6709), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6710), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6712), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6714), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6732), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6735), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6767), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6776), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6777), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6781), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6783), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6785), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6787), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6792), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6799), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6803), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localities",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 24, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(57), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(425), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(434), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(435), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(437), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(469), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(556), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(558), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Utilities",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 16, 55, 0, 25, DateTimeKind.Unspecified).AddTicks(559), new TimeSpan(0, 3, 0, 0, 0)));

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
        }
    }
}
