using System.Collections.Generic;
using System;
using TellAndTale.Items;

namespace TellAndTale
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Character> cha = new List<Character>();
            Character bigFrog = new BigFrog();
            Character ironBunny = new IronBunny();
            Character witchCat = new WitchCat();
            
            Ally ally = new Ally();

            List<Item> itemList = new List<Item>();
            Item item = new Item();
            Item sword = new Sword();
            Item wand = new Wand();
            Item axe = new Axe();
            Item dagger = new Dagger();
            
            ItemInventory inventory = new ItemInventory();
            
            // Starter allies and enemies
            ally.AddAlly(bigFrog);
            ally.AddAlly(ironBunny);
            ally.AddAlly(witchCat);
            
            // Display allies
            // ally.DisplayAllies();
            //
            // Starter items in inventory
            inventory.AddItem(sword);
            inventory.AddItem(wand);
            inventory.AddItem(axe);
            inventory.AddItem(dagger);
            
            // // Display items in inventory
            // inventory.DisplayInventory();
            
            //sword.AttachItem(new List<Character>(), new List<Item>());
            
            // Prologue
            Console.WriteLine("=============================================================================================================================\n");
            Console.WriteLine("Once upon a time in the Magical World, people lived peacefully in town. Suddenly, monsters appeared from nowhere so humanity started to crumble.");
            Console.WriteLine("Then the HOPE arrived. There was a group of adventurers who were on a quest to find the legendary treasure to save the world! They were called the TELL & TALE.");
            Console.WriteLine("\n=============================================================================================================================");
            Console.ReadKey();
            Console.Clear();

            Battle battle = new Battle();
            battle.BattleStart(ally, cha, inventory, item, itemList);
        }
    }
}