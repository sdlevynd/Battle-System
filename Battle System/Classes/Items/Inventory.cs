using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Items
{
    public class Inventory
    {
        private int size;
        private int items;
        private List<Item> itemList;   

        public Inventory() 
        {
            size = 10;
            items = 0;
            itemList = new List<Item>();
        }
        public void addItem(Item item)
        {
            if (items == size)
            {
                Console.WriteLine("inventory is full!");
                return;
            }
            items++;
            itemList.Add(item);
        }
        public Item GetItem(int index)
        {
            return itemList[index];
        }
        public string showItems()
        {
            string output = "";
            for (int i = 0; i < itemList.Count; i++)
            {
                output += $"{i+1}: {itemList[i].GetName()}\n";
            }
            return output;
        }
    }
}
