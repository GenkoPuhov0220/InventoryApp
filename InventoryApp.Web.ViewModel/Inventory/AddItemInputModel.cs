
namespace InventoryApp.Web.ViewModel.Inventory
{
    using System.ComponentModel.DataAnnotations;
    using static InventoryApp.Common.EntityValidationConstants.Inventory;
    public class AddItemInputModel
    {
        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(SupplierMinLength)]
        [MaxLength(SupplierMaxLength)]
        public string Supplier { get; set; } = null!;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be positive")]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        public decimal Price { get; set; }

    }
}
