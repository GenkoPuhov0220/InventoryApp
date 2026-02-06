using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Price", "Quantity", "Supplier", "Title" },
                values: new object[,]
                {
                    { new Guid("085978eb-05e1-4be3-9384-aa14212a6037"), 2500m, 5, "BMW", "Engine for BMW 3-series 3.0 Diesel" },
                    { new Guid("0e7437a3-8948-421f-b459-db177f330793"), 4100m, 2, "Audi", "Automatic Gearbox for Audi A4 B8" },
                    { new Guid("20ccf995-0033-4135-a071-0ed9aa0db956"), 390m, 6, "Volkswagen", "Starter Motor for VW Passat B7" },
                    { new Guid("4ba3c86b-9c5b-40e6-8428-b1acbca3bd85"), 3200m, 3, "BMW", "Engine for BMW 5-series 2.0 Diesel" },
                    { new Guid("59dde9db-8a8e-4cbd-858b-6c29d130990e"), 420m, 8, "BMW", "Fuel Injector for BMW 320d E90" },
                    { new Guid("65c5da32-4822-4ed8-9958-d5770f5604bc"), 650m, 4, "Mercedes-Benz", "Alternator for Mercedes E-Class W212" },
                    { new Guid("99ff52ab-71f5-420b-b8c0-e52e55c4e8e3"), 1100m, 3, "BMW", "Timing Chain Kit for BMW N47 Engine" },
                    { new Guid("9b68ede3-19c6-4954-81b6-bdf0695b2a88"), 1800m, 4, "BMW", "Suspension Kit for BMW X5 E70" },
                    { new Guid("9e3b5667-6da5-456e-ba60-b24f41ad6fa0"), 650m, 7, "Opel", "Clutch Set for Opel Insignia 2.0 CDTI" },
                    { new Guid("c4dcd3b6-51a3-4a9a-b34a-507e12f684c8"), 850m, 10, "Mercedes-Benz", "Brake Kit for Mercedes C-Class W205" },
                    { new Guid("d2a5ec85-cfac-4d20-8714-55fb69b105dc"), 2200m, 2, "Audi", "Air Suspension Compressor for Audi Q7" },
                    { new Guid("d48c9eca-6dd6-45dd-adb3-068228ffbd55"), 1200m, 6, "Volkswagen", "Turbocharger for VW Golf 7 2.0 TDI" },
                    { new Guid("f2607650-2282-4f91-bfdb-88c915567aad"), 780m, 5, "Audi", "Radiator for Audi A6 C7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
