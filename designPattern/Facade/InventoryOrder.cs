using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Facade
{
    public class InventoryOrder
    {
        public string CreateOrder(ShoppingBasket basket)
        {
            basket.GetItems();

            return $"Order Number is {System.Guid.NewGuid().ToString()}";
        }
    }
}
