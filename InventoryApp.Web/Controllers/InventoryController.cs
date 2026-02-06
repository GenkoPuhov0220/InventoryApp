using InventoryApp.Data;
using InventoryApp.Data.Models;
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
        public IActionResult Create(Inventory inventory)
        {
            
            dbContext.Inventories.Add(inventory);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
