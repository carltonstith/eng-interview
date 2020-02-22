using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InmateLocator.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inmates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PID = table.Column<string>(maxLength: 6, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CurrentLocation = table.Column<string>(maxLength: 100, nullable: false),
                    InmateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Inmates_InmateId",
                        column: x => x.InmateId,
                        principalTable: "Inmates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Inmates",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "PID" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), new DateTimeOffset(new DateTime(1680, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Dan", "Lopez", "123456" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), new DateTimeOffset(new DateTime(1780, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Ronald", "Pax", "598744" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new DateTimeOffset(new DateTime(1650, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Arnold", "Phillips", "732123" },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), new DateTimeOffset(new DateTime(1753, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Brian", "Dawkins", "584123" },
                    { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), new DateTimeOffset(new DateTime(1623, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Christopher", "Wallace", "852014" },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), new DateTimeOffset(new DateTime(1801, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Johnathan", "Hugh", "987456" },
                    { new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"), new DateTimeOffset(new DateTime(1668, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, -57, 0, 0)), "Rick", "Flair", "741258" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CurrentLocation", "InmateId" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), "City Hall", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35") },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "City Hall", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35") },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "City Hall", new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") },
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), "City Hall", new Guid("2902b665-1190-4c70-9915-b9c2d7680450") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_InmateId",
                table: "Locations",
                column: "InmateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Inmates");
        }
    }
}
