using InventoryApp.Data;
using InventoryApp.Data.Models;
using InventoryApp.Web.ViewModel.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Web.Controllers
{
    public class InventoryController : Controller
    {
        private InventoryDbContext dbContext;

        public InventoryController(InventoryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            IEnumerable<Inventory> allInventories = await dbContext
                .Inventories
                .Where(i => i.IsDeleted == false)
                .ToListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                allInventories = allInventories
                    .Where(i => i.Title.ToLower().Contains(searchString.ToLower()));
            }
            return View(allInventories);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddItemInputModel inventory)
        {
            if (!ModelState.IsValid)
            {
                return View(inventory);
            }

            Inventory newInventory = new Inventory()
            {
                Title = inventory.Title,
                Supplier = inventory.Supplier,
                Quantity = inventory.Quantity,
                Price = inventory.Price
            };

            await dbContext.Inventories.AddAsync(newInventory);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return RedirectToAction(nameof(Index));
            }

            bool IsGuidValid = Guid.TryParse(id, out Guid inventoryGuid);
            if (!IsGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Inventory? item = dbContext.Inventories
                 .FirstOrDefault(i => i.Id == inventoryGuid);

            if (item == null)
            {
                return RedirectToAction(nameof(Index));
            }

            EditItemViewModel newInventory = new EditItemViewModel
            {
                Title = item.Title,
                Supplier = item.Supplier,
                Quantity = item.Quantity,
                Price = item.Price
            };

            return View(newInventory);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, EditItemViewModel inventory)
        {
            if (!ModelState.IsValid)
            {
                return View(inventory);
            }

            bool IsGuidValid = Guid.TryParse(id, out Guid inventoryGuid);
            if (!IsGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Inventory? item = await dbContext.Inventories
            .FirstOrDefaultAsync(i => i.Id == inventoryGuid);

            if (item == null)
            {
                return RedirectToAction(nameof(Index));
            }

            item.Title = inventory.Title;
            item.Supplier = inventory.Supplier;
            item.Quantity = inventory.Quantity;
            item.Price = inventory.Price;

            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> Delete(string? id)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return RedirectToAction(nameof(Index));
            }

            bool IsGuidValid = Guid.TryParse(id, out Guid inventoryGuid);
           
            if (!IsGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Inventory? item = await dbContext.Inventories
                .FirstOrDefaultAsync(i => i.Id == inventoryGuid);

            if (item == null)
            {
                return RedirectToAction(nameof(Index));
            }

            DeleteItemViewModel itemforDelete = new DeleteItemViewModel
            {
                Title = item.Title,
                Supplier = item.Supplier,
                Quantity = item.Quantity,
                Price = item.Price
            };

            return View(itemforDelete);

        }
        [HttpPost]
        public async Task<IActionResult> ConfirmedDelete(string id)
        {
            bool IsGuidValid = Guid.TryParse(id, out Guid inventoryGuid);
            if (!IsGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Inventory? item = await dbContext.Inventories
                .FirstOrDefaultAsync(i => i.Id == inventoryGuid);

            if (item == null)
            {
                return RedirectToAction(nameof(Index));
            }

            item.IsDeleted = true;

            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }  


    }
}
