using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductOperation.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductionOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    StoppingReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOperations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandartStoppings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoppingReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandartStoppings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductionOperations",
                columns: new[] { "Id", "CreatedDate", "EndDateTime", "No", "StartDateTime", "Status", "StoppingReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), "İş 1", new DateTime(2020, 5, 23, 7, 30, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "İş 2", new DateTime(2020, 5, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "İş 3", new DateTime(2020, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 13, 45, 0, 0, DateTimeKind.Unspecified), "Duruş 1", new DateTime(2020, 5, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Arıza", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), "İş 4", new DateTime(2020, 5, 23, 13, 45, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StandartStoppings",
                columns: new[] { "Id", "CreatedDate", "EndDateTime", "StartDateTime", "StoppingReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), "Çay Molası", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Yemek Molası", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 15, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "Çay Molası", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionOperations");

            migrationBuilder.DropTable(
                name: "StandartStoppings");
        }
    }
}
