using System;
using rpgproject.models;

namespace rpgproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Item healthPotion = new Item("Health Potion", 2, 10);
            Item stone = new Item("Stone", 1, 0);
            Item herb = new Item("Herb", 1, 2);
            Item hat = new Item("Hat", 2, 100);
            
            Weapon sword = new Weapon("Sword", 20, 200, 10, 100);
            //Ranged bow = new Ranged("Bow", 10, 200, 5, 50, 1, 5);
            //Magic wand = new Magic("Wand", 10, 200, 5, 50, 1, 5, 2);

            RPGCharacter fred = new RPGCharacter("Fred", 200, 20);
            RPGCharacter defaultCharacter = new RPGCharacter();

            fred.BackPack.AddNewItem(healthPotion);
            fred.BackPack.AddNewItem(stone);
            fred.BackPack.AddNewItem(hat);
            // add herb
            //add another herb

            //sort freds by weight
            System.Console.WriteLine($"Fred's Backpack\n {fred.BackPack.ListItems()}");
            //print current capacity
            //print number of health potions


            defaultCharacter.BackPack.SortByName();
            System.Console.WriteLine($"Default Backpack\n {defaultCharacter.BackPack.ListItems()}");


            System.Console.WriteLine($"{defaultCharacter.BackPack.Items[0].Name} DMG: {((Weapon)defaultCharacter.BackPack.Items[0]).Damage}");

            //go through default backpack and see what is an item and what is a weapon
            foreach(Item i in defaultCharacter.BackPack.Items) {
                if (i is Item) {
                    System.Console.WriteLine($"{i.Name} is an Item");
                }
                if (i is Weapon) {
                    System.Console.WriteLine($"{i.Name} is a Weapon");
                }
            }
        }
    }
}
