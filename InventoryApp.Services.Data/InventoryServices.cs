
using InventoryApp.Data;
using InventoryApp.Services.Data.Interfaces;
using InventoryApp.Web.ViewModel.Inventory;
using InventoryApp.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace InventoryApp.Services.Data
{
    public class InventoryServices : IInventoryServices
    {
        private readonly InventoryDbContext dbContext;
        public InventoryServices(InventoryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Inventory>> IndexGetAllAsync()
        {
            return await dbContext.Inventories
                .Where(i => !i.IsDeleted)
                .ToListAsync();

        }
        public async Task CreateAsync(AddItemInputModel model)
        {
            var inventory = new Inventory
            {
                Title = model.Title,
                Supplier = model.Supplier,
                Quantity = model.Quantity,
                UnitPrice = model.UnitPrice,
                Price = model.UnitPrice * model.Quantity,
            };

            dbContext.Inventories.Add(inventory);
            await dbContext.SaveChangesAsync();

        }
        public async Task<EditItemViewModel?> GetForEditAsync(string id)
        {
            if(!Guid.TryParse(id, out var inventoryId))
            {
                return null;
            }

            var item = await dbContext.Inventories
                .FirstOrDefaultAsync(i => i.Id == inventoryId);

            if(item == null)
            {
                return null;
            }
            var model = new EditItemViewModel
            {
                Title = item.Title,
                Supplier = item.Supplier,
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                Price = item.Price,
            };

            return model;
        }

        public async Task EditAsync(string id, EditItemViewModel item)
        {
            if (!Guid.TryParse(id, out var inventoryId))
            {
                return;
            }

            var editItem = await dbContext.Inventories
               .FirstOrDefaultAsync(i => i.Id == inventoryId);

            if (item == null)
            {
                return;
            }

            editItem.Title = item.Title;
            editItem.Supplier = item.Supplier;
            editItem.Quantity = item.Quantity;
            editItem.UnitPrice = item.UnitPrice;
            editItem.Price = item.UnitPrice * item.Quantity;
        }

        public async Task<DeleteItemViewModel?> GetForDeleteAsync(string id)
        {
            if (!Guid.TryParse(id, out var inventoryId))
            {
                return null;
            }
            var deleteItem = await dbContext.Inventories
                .FirstOrDefaultAsync(i => i.Id == inventoryId);

            if (deleteItem == null)
            {
                return null;
            }
            var itemForDelete = new DeleteItemViewModel
            {
                Title = deleteItem.Title,
                Supplier = deleteItem.Supplier,
                Quantity = deleteItem.Quantity,
                UnitPrice = deleteItem.UnitPrice,
                Price = deleteItem.Price,
            };
            return itemForDelete;
        }
            
        public async Task DeleteAsync(string id)
        {
            if(!Guid.TryParse(id, out var inventoryId))
            {
                return;
            }

            var deleteItem = await dbContext.Inventories
                    .FirstOrDefaultAsync(i => i.Id == inventoryId);

            if (deleteItem == null)
            {
              return;
            }

            deleteItem.IsDeleted = true;
            await dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<ReportItemViewModel>> GetReportAsync()
        {
            var report = await dbContext.Inventories
                .Where(i => !i.IsDeleted)
                .Select(i => new ReportItemViewModel
                {
                    Title = i.Title,
                    Supplier = i.Supplier,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice,
                    Price = i.Price,
                })
                .ToListAsync();

            return report;
        }
    }
}
