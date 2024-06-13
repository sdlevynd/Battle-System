using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        public Player(string name) : base(name)
        {
            EquipItem(new Weapon("sword", "a basic sword", 1));
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
        }

        internal void GiveItem(Item item)
        {
            
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
        }
    }
    public class Mage : Player
    {
        public Mage(string name) : base(name)
        {
            strength = 1;
            mp = 20;
        }
    }
}
