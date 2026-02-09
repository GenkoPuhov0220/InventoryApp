using InventoryApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace InventoryApp.Data.Configuration
{
    using static Common.EntityValidationConstants.Inventory;
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);
            builder
                .Property(i => i.Supplier)
                .IsRequired()
                .HasMaxLength(SupplierMaxLength);
            builder
                .Property(i => i.Price)
                .HasColumnType("decimal(18,2)");
            builder 
                .Property(i => i.IsDeleted)
                .HasDefaultValue(false);
            builder
                .HasData(this.SeedInventory());
        }
        private List<Inventory> SeedInventory()
        {
            List<Inventory> inventory = new List<Inventory>()
            {
                new Inventory()
                {
                    Title = "Engine for BMW 3-series 3.0 Diesel",
                    Supplier = "BMW",
                    Quantity = 5,
                    Price = 2500m
                },
                new Inventory()
                {
                    Title = "Engine for BMW 5-series 2.0 Diesel",
                    Supplier = "BMW",
                    Quantity = 3,
                    Price = 3200m
                },
                new Inventory()
                {
                    Title = "Automatic Gearbox for Audi A4 B8",
                    Supplier = "Audi",
                    Quantity = 2,
                    Price = 4100m
                },
                new Inventory()
                {
                    Title = "Turbocharger for VW Golf 7 2.0 TDI",
                    Supplier = "Volkswagen",
                    Quantity = 6,
                    Price = 1200m
                },
                new Inventory()
                {
                    Title = "Brake Kit for Mercedes C-Class W205",
                    Supplier = "Mercedes-Benz",
                    Quantity = 10,
                    Price = 850m
                },
                new Inventory()
                {
                    Title = "Clutch Set for Opel Insignia 2.0 CDTI",
                    Supplier = "Opel",
                    Quantity = 7,
                    Price = 650m
                },
                new Inventory()
                {
                    Title = "Suspension Kit for BMW X5 E70",
                    Supplier = "BMW",
                    Quantity = 4,
                    Price = 1800m
                },
                new Inventory()
                {
                    Title = "Fuel Injector for BMW 320d E90",
                    Supplier = "BMW",
                    Quantity = 8,
                    Price = 420m
                },
                new Inventory()
                {
                    Title = "Radiator for Audi A6 C7",
                    Supplier = "Audi",
                    Quantity = 5,
                    Price = 780m
                },
                new Inventory()
                {
                    Title = "Alternator for Mercedes E-Class W212",
                    Supplier = "Mercedes-Benz",
                    Quantity = 4,
                    Price = 650m
                },
                new Inventory()
                {
                    Title = "Starter Motor for VW Passat B7",
                    Supplier = "Volkswagen",
                    Quantity = 6,
                    Price = 390m
                },
                new Inventory()
                {
                    Title = "Timing Chain Kit for BMW N47 Engine",
                    Supplier = "BMW",
                    Quantity = 3,
                    Price = 1100m
                },
                new Inventory()
                {
                    Title = "Air Suspension Compressor for Audi Q7",
                    Supplier = "Audi",
                    Quantity = 2,
                    Price = 2200m
                }

            };
            return inventory;
        }
    }
}
