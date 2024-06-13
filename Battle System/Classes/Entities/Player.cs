﻿using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            ClassName = "Fighter";
            EquipItem(new Weapon("sword", "a basic sword", 1));
        }
    }
    public class Archer : Player
    {
        public Archer(string name) : base(name)
        {
            strength = 5;
            ClassName = "Archer";
            EquipItem(new Weapon("bow", "a basic bow", 1));
        }
        public override int Attack()
        {
            //choose a type of attack to do
            if (mp > 5)
            {
                mp -= 2;
                return 10;
            }
            else
            {
                Console.WriteLine("you don't have enough mp!");
                return base.Attack();
            }
        }
    }
}
