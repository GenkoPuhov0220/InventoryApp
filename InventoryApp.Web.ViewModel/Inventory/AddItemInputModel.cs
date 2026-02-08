
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
        [MinLength(QuantityMinValue)]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}
