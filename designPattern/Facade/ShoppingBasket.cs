using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Facade
{
    public class ShoppingBasket
    {
        private List<BasketItem> items = new List<BasketItem>();

        public void AddItem(BasketItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(string itemId)
        {
            var item = items.Where(x => x.ItemId == itemId).Single();
            if (item.Quantity > 0)
            {
                item.Quantity = item.Quantity - 1;
            }
        }

        public List<BasketItem> GetItems()
        {
            return items;
        }
    }
}
