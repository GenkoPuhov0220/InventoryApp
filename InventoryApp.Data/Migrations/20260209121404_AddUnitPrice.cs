using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUnitPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("13c2ade7-5831-45f0-a688-6be9b6c61138"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("17bc9ec4-ab00-489b-8435-0cb960ffa9c6"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1ff31e1a-6f46-461c-a05a-34634e79c9b7"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("2cde4658-859c-42ff-8ccc-656a54976435"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("437be437-7e1f-46e0-832d-f8458e4a4363"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("48359c3f-59d3-4388-b41c-aacba5b95737"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4f89b342-bc55-4c83-aa0c-02826eefb571"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("64cfe0b7-d90c-4009-9b49-9037fe85c852"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("6831fa9c-83c6-4abd-89e5-106c4b09438f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("6e64189b-fe0d-477b-b67d-7cfba2b4e2aa"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("8aed8b9c-7aab-4009-a94f-ce48d24faf3c"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("94f559e8-1b05-4165-a0c8-7d9c3342b293"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d6110ad1-22e3-4e1e-aab2-b80ea319f42a"));

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Inventories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Price", "Quantity", "Supplier", "Title", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("1a890e5d-6e8e-4dae-af1f-474c76c9d008"), 1100m, 3, "BMW", "Timing Chain Kit for BMW N47 Engine", 366.67m },
                    { new Guid("3112a173-bd44-4b81-b1b0-56ad79d80462"), 850m, 10, "Mercedes-Benz", "Brake Kit for Mercedes C-Class W205", 85m },
                    { new Guid("3dd2bb17-c0be-4763-92d2-3b0bfa275b41"), 1800m, 4, "BMW", "Suspension Kit for BMW X5 E70", 450m },
                    { new Guid("3fd17b03-5233-4e6f-a799-34f9ec7a17cb"), 650m, 4, "Mercedes-Benz", "Alternator for Mercedes E-Class W212", 162.50m },
                    { new Guid("4969bcf2-9067-4662-ac5e-07a77a14abe9"), 4100m, 2, "Audi", "Automatic Gearbox for Audi A4 B8", 2050m },
                    { new Guid("751c40cd-3b32-499c-8135-5c673c7be41a"), 2500m, 5, "BMW", "Engine for BMW 3-series 3.0 Diesel", 500m },
                    { new Guid("9644ea59-0c94-4552-98f2-5557a9e24f15"), 780m, 5, "Audi", "Radiator for Audi A6 C7", 156m },
                    { new Guid("a6b3ac66-4b56-4ac0-a514-270291e6a6f9"), 1200m, 6, "Volkswagen", "Turbocharger for VW Golf 7 2.0 TDI", 200m },
                    { new Guid("b513bdd4-8762-4fec-ac1c-d6b1e103e7b6"), 650m, 7, "Opel", "Clutch Set for Opel Insignia 2.0 CDTI", 92.86m },
                    { new Guid("cc55c101-70d4-4698-a432-0b59e9613b4c"), 420m, 8, "BMW", "Fuel Injector for BMW 320d E90", 52.50m },
                    { new Guid("d8bc1d18-5b35-4d6f-a194-5055b7a55591"), 3200m, 3, "BMW", "Engine for BMW 5-series 2.0 Diesel", 1066.67m },
                    { new Guid("ee2d042d-7440-4261-8035-0fcc272a7092"), 2200m, 2, "Audi", "Air Suspension Compressor for Audi Q7", 1100m },
                    { new Guid("f724ed54-7ec3-4b84-ad48-ec75ceb90c98"), 390m, 6, "Volkswagen", "Starter Motor for VW Passat B7", 65m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1a890e5d-6e8e-4dae-af1f-474c76c9d008"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3112a173-bd44-4b81-b1b0-56ad79d80462"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3dd2bb17-c0be-4763-92d2-3b0bfa275b41"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3fd17b03-5233-4e6f-a799-34f9ec7a17cb"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4969bcf2-9067-4662-ac5e-07a77a14abe9"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("751c40cd-3b32-499c-8135-5c673c7be41a"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9644ea59-0c94-4552-98f2-5557a9e24f15"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ac66-4b56-4ac0-a514-270291e6a6f9"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b513bdd4-8762-4fec-ac1c-d6b1e103e7b6"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("cc55c101-70d4-4698-a432-0b59e9613b4c"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d8bc1d18-5b35-4d6f-a194-5055b7a55591"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ee2d042d-7440-4261-8035-0fcc272a7092"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f724ed54-7ec3-4b84-ad48-ec75ceb90c98"));

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Inventories");

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Price", "Quantity", "Supplier", "Title" },
                values: new object[,]
                {
                    { new Guid("13c2ade7-5831-45f0-a688-6be9b6c61138"), 1100m, 3, "BMW", "Timing Chain Kit for BMW N47 Engine" },
                    { new Guid("17bc9ec4-ab00-489b-8435-0cb960ffa9c6"), 3200m, 3, "BMW", "Engine for BMW 5-series 2.0 Diesel" },
                    { new Guid("1ff31e1a-6f46-461c-a05a-34634e79c9b7"), 4100m, 2, "Audi", "Automatic Gearbox for Audi A4 B8" },
                    { new Guid("2cde4658-859c-42ff-8ccc-656a54976435"), 420m, 8, "BMW", "Fuel Injector for BMW 320d E90" },
                    { new Guid("437be437-7e1f-46e0-832d-f8458e4a4363"), 650m, 4, "Mercedes-Benz", "Alternator for Mercedes E-Class W212" },
                    { new Guid("48359c3f-59d3-4388-b41c-aacba5b95737"), 850m, 10, "Mercedes-Benz", "Brake Kit for Mercedes C-Class W205" },
                    { new Guid("4f89b342-bc55-4c83-aa0c-02826eefb571"), 1800m, 4, "BMW", "Suspension Kit for BMW X5 E70" },
                    { new Guid("64cfe0b7-d90c-4009-9b49-9037fe85c852"), 1200m, 6, "Volkswagen", "Turbocharger for VW Golf 7 2.0 TDI" },
                    { new Guid("6831fa9c-83c6-4abd-89e5-106c4b09438f"), 2500m, 5, "BMW", "Engine for BMW 3-series 3.0 Diesel" },
                    { new Guid("6e64189b-fe0d-477b-b67d-7cfba2b4e2aa"), 780m, 5, "Audi", "Radiator for Audi A6 C7" },
                    { new Guid("8aed8b9c-7aab-4009-a94f-ce48d24faf3c"), 2200m, 2, "Audi", "Air Suspension Compressor for Audi Q7" },
                    { new Guid("94f559e8-1b05-4165-a0c8-7d9c3342b293"), 390m, 6, "Volkswagen", "Starter Motor for VW Passat B7" },
                    { new Guid("d6110ad1-22e3-4e1e-aab2-b80ea319f42a"), 650m, 7, "Opel", "Clutch Set for Opel Insignia 2.0 CDTI" }
                });
        }
    }
}
