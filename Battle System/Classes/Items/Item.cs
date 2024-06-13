using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Items
{
    public class Item
    {
        protected string name;
        protected int id;
        protected string description;
        protected bool equipable;

        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
            equipable = false;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return description;
        }
        public bool IsEquipable()
        {
            return equipable;
        }
    }
}
