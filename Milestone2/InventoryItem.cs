using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneProejct
{
    class InventoryItem
    {
        //Inventory item constructor
        public InventoryItem(string itemType, string itemName, int quantity, int itemPrice)
        {
            ItemType = itemType;
            ItemName = itemName;
            Quantity = quantity;
            ItemPrice = itemPrice;
        }

        //Variables and naming for methods. 
        private int IdName { get; } //No setter needed for Item ids will stay constant. 
        private string ItemName { get; set; }
        private double Quantity { get; set; }
        private double ItemPrice { get; set; }
        private string ItemType { get; set; }

        //Creating methods 
        public void Order(int howMany)
        {
            Quantity += howMany;
        }

        //Remove item given variable in parameters for null value. 
        public void RemoveItem(int Z = 0)
        {
            Quantity = Z;
        }
        //Update quantity value with new Item amount. 
        public void AddItem(int howMany)
        {
            Quantity += howMany;
        }
    }
}
