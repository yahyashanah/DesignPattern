using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Facade
{
    public class PurchaseOrder
    {
        public bool CreateOrder(ShoppingBasket basket,string custInfo)
        {

            // check stock
            bool isAvailable = true;
            Inventory inventory = new Inventory();
            foreach(var item in basket.GetItems())
            {
                if (!inventory.CheckItemQuantity(item.ItemId, item.Quantity))
                    isAvailable = false;
            }
            
            if (isAvailable)
            {
                // Create Inventory Order
                InventoryOrder inventoryOrder = new InventoryOrder();
                inventoryOrder.CreateOrder(basket);

                // Create Invoice
                PurchaseInvoice invoice = new PurchaseInvoice();
                var inv = invoice.CreateInvoice(basket, "address:123,id=321,email=yahya");

                //Payment 
                PaymentProcessor payment = new PaymentProcessor();
                payment.HandlePayment(inv.netTotal, "acc = 123456789");

                // Send Sms
                SmsNotification sms = new SmsNotification();
                sms.SendSms("123", "Invoice Created");

                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
