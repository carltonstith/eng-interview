using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InmateLocator.Migrations
{
    public partial class DOBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1953, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1950, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1991, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1968, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1993, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1753, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1650, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1801, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1668, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1623, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1680, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Inmates",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                column: "DateOfBirth",
                value: new DateTimeOffset(new DateTime(1780, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)));
        }
    }
}
