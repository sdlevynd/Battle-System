using Battle_System;
using Battle_System.Classes.Entities;
using Battle_System.Classes.Items;

namespace Battle_System
{
    public class Tests
    {
        Player testPlayer;

        [SetUp]
        public void Setup()
        {
            
        }
        [Test]
        public void Test1()
        {
            testPlayer = new Fighter("test player");
            testPlayer.EquipItem(new Weapon("test weapon", "this is a test weapon", 123));
            Assert.That(testPlayer.Attack(), Is.EqualTo(123 * 5));
        }
    }
}