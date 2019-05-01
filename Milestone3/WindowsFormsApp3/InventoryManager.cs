using MilestoneProejct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class InventoryManager
    {
        //array for the inventory items
        InventoryItem[] yourInventory = new InventoryItem[10];
        private int inventoryFinalIndex = 0;

        //putting values in the array. 
        public InventoryManager()
        {
            yourInventory[0] = new InventoryItem("Broom", 6, 29.00m, "Supplies");
            yourInventory[1] = new InventoryItem("Blender", 200, .50m, "Kitchen Appliance");
            yourInventory[2] = new InventoryItem("Paper", 800, 7.56m, "Office Supplies");
            yourInventory[3] = new InventoryItem("Toaster", 11, 56.51m, "Kitchen Appliance");
            yourInventory[4] = new InventoryItem("A1", 24, 2.37m, "Spices");
            inventoryFinalIndex = 5;
        }

        public void addItem(string itemName, int quantity, decimal itemPrice, string itemCategory)
        {
            yourInventory[inventoryFinalIndex] = new InventoryItem(itemName, quantity, itemPrice, itemCategory);
            inventoryFinalIndex++;
        }

        public void removeItem(int index)
        {
            //delete item from inventory.
            for (int i = 0; (i + index) <= (yourInventory.Length - 1); i++)
            {
                if (index + i == yourInventory.Length - 1)
                {
                    //The final index will be replaced with null.
                    yourInventory[index + i] = null;
                }
                else
                {
                    //shift the elements to the left within the array.
                    yourInventory[index + i] = yourInventory[index + i + 1];
                }
            }
            inventoryFinalIndex--;
        }

        //restock a single item in the inverntory
        public void restockItem(int index, int quantity)
        {
            yourInventory[index].AddItem(quantity);
        }

        //show the inventory.
        public void displayInventory()
        {
            for (int i = 0; i < inventoryFinalIndex; i++)
            {
                Console.WriteLine(yourInventory[i].ToString());
            }
        }

        //show individual items in the inventory
        public string displaySingleItem(int index)
        {
            return yourInventory[index].ToString();
        }

        //search the inventory for an item. Returns the index of the item.      
        public int searchInventory(string searchCriteria, string lookingFor)
        {
            switch (searchCriteria)
            {
                case "name":

                    for (int index = 0; index < yourInventory.Length; index++)
                    {
                        if (yourInventory[index].ItemName == lookingFor)
                        {
                            return index;
                        }

                        if (index == yourInventory.Length - 1)
                        {
                            return -1;
                        }
                    }

                    break;

                case "quantity":

                    for (int index = 0; index < yourInventory.Length; index++)
                    {
                        if (yourInventory[index].Quantity == int.Parse(lookingFor))
                        {
                            return index;
                        }

                        if (index == yourInventory.Length - 1)
                        {
                            return -1;
                        }
                    }

                    break;
            }
            //if there is an error return the value. 
            return -1;
        }
    }
}
