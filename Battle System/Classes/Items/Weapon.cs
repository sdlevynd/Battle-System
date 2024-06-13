using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Items
{
    public class Weapon : Item
    {
        private int attack;
        public Weapon(string name, string description, int attack) : base(name, description)
        {
            this.attack = attack;
            equipable = true;
        }
        public int getAttack()
        {
            return attack;
        }
    }
}