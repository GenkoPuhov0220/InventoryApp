using InventoryApp.Data;
using InventoryApp.Data.Models;
using InventoryApp.Services.Data;
using InventoryApp.Services.Data.Interfaces;
using InventoryApp.Web.ViewModel.Inventory;
using Moq;
using Moq.EntityFrameworkCore;

namespace InventoryApp.Services.Tests
{
    [TestFixture]
    public class InventoryServiceTests
    {
        private Mock<InventoryDbContext> mockdbContext;
        private InventoryServices inventoryService;

        [SetUp]
        public void Setup()
        {
            mockdbContext = new Mock<InventoryDbContext>();
            inventoryService = new InventoryServices(mockdbContext.Object);
        }

        [Test]
        public async Task IndexGetAllAsyncReturnInventories()
        {
            var inventories = new List<Inventory>
          {
              new Inventory
              {
                  Title = "Test Item1",
                  IsDeleted = false,

              },
              new Inventory
              {
                  Title = "Test Item2",
                  IsDeleted = true,
              }
          };


            mockdbContext
                .Setup(db => db.Inventories)
                .ReturnsDbSet(inventories);

            var result = await inventoryService
                .IndexGetAllAsync();

            Assert.AreEqual(1, result.Count());
            Assert.IsFalse(result.First().IsDeleted);

        }
    }
}