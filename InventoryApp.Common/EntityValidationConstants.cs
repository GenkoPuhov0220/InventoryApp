using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Common
{
    public class EntityValidationConstants
    {
        public static class Inventory
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 200;
            public const int SupplierMaxLength = 100;
            public const int SupplierMinLength = 2;
            public const int QuantityMinValue = 1;

        }
    }
}
