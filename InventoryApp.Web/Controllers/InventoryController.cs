using InventoryApp.Data;
using InventoryApp.Data.Models;
using InventoryApp.Web.ViewModel.Inventory;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            IEnumerable<Inventory> allInventories = dbContext
                .Inventories
                .ToList();

            return View(allInventories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddItemInputModel inventory)
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

            dbContext.Inventories.Add(newInventory);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
