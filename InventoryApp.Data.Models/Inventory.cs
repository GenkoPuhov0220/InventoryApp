using System.Diagnostics;

namespace InventoryApp.Data.Models
{
    public class Inventory
    {
        public Inventory()
        {
            this.Id = Guid.NewGuid();
        }
        public  Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Supplier { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
