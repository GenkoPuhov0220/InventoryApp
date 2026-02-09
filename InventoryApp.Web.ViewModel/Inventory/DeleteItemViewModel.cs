

namespace InventoryApp.Web.ViewModel.Inventory
{
    public class DeleteItemViewModel
    {
        public string Title { get; set; } = null!;
        public string Supplier { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
