using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("085978eb-05e1-4be3-9384-aa14212a6037"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0e7437a3-8948-421f-b459-db177f330793"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("20ccf995-0033-4135-a071-0ed9aa0db956"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4ba3c86b-9c5b-40e6-8428-b1acbca3bd85"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("59dde9db-8a8e-4cbd-858b-6c29d130990e"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("65c5da32-4822-4ed8-9958-d5770f5604bc"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("99ff52ab-71f5-420b-b8c0-e52e55c4e8e3"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9b68ede3-19c6-4954-81b6-bdf0695b2a88"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9e3b5667-6da5-456e-ba60-b24f41ad6fa0"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c4dcd3b6-51a3-4a9a-b34a-507e12f684c8"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d2a5ec85-cfac-4d20-8714-55fb69b105dc"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d48c9eca-6dd6-45dd-adb3-068228ffbd55"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f2607650-2282-4f91-bfdb-88c915567aad"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Inventories",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Inventories");

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
    }
}
