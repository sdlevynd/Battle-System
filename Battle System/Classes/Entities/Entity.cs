using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_System.Classes.Items;

namespace Battle_System.Classes.Entities
{
    public class Entity
    {
        protected Random rng;
        protected int hp;
        protected int mp;
        protected string name;

        protected int strength;

        private Inventory inventory;
        protected Weapon weapon = new Weapon("No weapon", "you do not have a weapon", 1);

        public Entity(string name)
        {
            this.name = name;
            hp = 10;
            mp = 10;
            strength = 1;
            rng = new Random();
        }
        public string GetName()
        {
            return name;
        }
        public int Attack()
        {
            if (rng.Next(10) < 8)
            {
                return strength * weapon.getAttack();
            }
            else
            {
                return 0;
            }
        }
        public void Damage(int damage)
        {
            hp -= damage;
        }
        public int GetHp()
        {
            return hp;
        }
        public void GiveItem(Item item)
        {
            inventory.addItem(item);
        }
        public void EquipItem(Item item)
        {
            if (item.IsEquipable())
            {
                weapon = (Weapon)item;
            }
        }
        public string GetWeaponName()
        {
            return weapon.GetName();
        }
        public string GetWeaponDescription()
        {
            return weapon.GetDescription();
        }
    }
}
