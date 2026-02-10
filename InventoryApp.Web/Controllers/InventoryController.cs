using InventoryApp.Data;
using InventoryApp.Data.Models;
using InventoryApp.Services.Data.Interfaces;
using InventoryApp.Web.ViewModel.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Web.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryServices inventoryServices;
        public InventoryController(IInventoryServices _inventoryServices)
        {
            inventoryServices = _inventoryServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {

            var allInventories = await inventoryServices
                .IndexGetAllAsync();
           
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
            await inventoryServices.CreateAsync(inventory);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            var editInventory = await inventoryServices.GetForEditAsync(id);
            

            if (editInventory == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(editInventory);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id,EditItemViewModel inventory)
        {
            if (!ModelState.IsValid)
            {
                return View(inventory);
            }

            await inventoryServices.EditAsync(id, inventory);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> Delete(string? id)
        {
            var itemForDelete = await inventoryServices
                .GetForDeleteAsync(id);

            if (itemForDelete == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(itemForDelete);


        }
        [HttpPost]
        public async Task<IActionResult> ConfirmedDelete(string id)
        {
            await inventoryServices.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Report()
        {
            var report = await inventoryServices.GetReportAsync();
            return View(report);
        }

    }
}
