
using System.ComponentModel.DataAnnotations;
namespace InventoryApp.Web.ViewModel.Inventory
{
    public class EditItemViewModel
    {
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Supplier { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
