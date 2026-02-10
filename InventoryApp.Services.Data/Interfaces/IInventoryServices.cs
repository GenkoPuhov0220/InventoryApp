
using InventoryApp.Web.ViewModel.Inventory;
using InventoryApp.Data.Models;
namespace InventoryApp.Services.Data.Interfaces
{
    public interface IInventoryServices
    {
        Task<IEnumerable<Inventory>> IndexGetAllAsync();

        Task CreateAsync(AddItemInputModel model);
        Task<EditItemViewModel?> GetForEditAsync(string id);
        Task EditAsync(string id, EditItemViewModel model);

        Task<DeleteItemViewModel?> GetForDeleteAsync(string id);
        Task DeleteAsync(string id);
        Task<IEnumerable<ReportItemViewModel>> GetReportAsync();
    }
}
