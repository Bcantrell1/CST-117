using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneProejct
{
    public class InventoryItem
    {
        //Variables and naming for methods. 
        public int IdName { get; } //No setter needed for Item ids will stay constant. 
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        private decimal ItemPrice { get; set; }
        private string ItemType { get; set; }
        private static int totalQuantity = 1; //Id 
        private string itemCategory;

        //Inventory item constructor
        public InventoryItem(string itemType, string itemName, int quantity, decimal itemPrice)
        {
            ItemType = itemType;
            ItemName = itemName;
            Quantity = quantity;
            ItemPrice = itemPrice;
            totalQuantity++;
        }

        public InventoryItem(string itemName, int quantity, decimal itemPrice, string itemCategory)
        {
            ItemName = itemName;
            Quantity = quantity;
            ItemPrice = itemPrice;
            this.itemCategory = itemCategory;
        }



        //Creating methods 
        public void Order(int howMany)
        {
            Quantity += howMany;
        }

        //Remove item given variable in parameters for null value. 
        public void RemoveItem(int howMany)
        {
            Quantity = howMany;
        }
        //Update quantity value with new Item amount. 
        public void AddItem(int howMany)
        {
            Quantity += howMany;
        }
        public new string ToString()
        {
            return ItemName + " " + Quantity + " " + ItemType;
        }
    }
}
