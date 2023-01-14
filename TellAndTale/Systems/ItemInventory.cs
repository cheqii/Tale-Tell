using System.Collections.Generic;
using System;
using TellAndTale.Items;

namespace TellAndTale
{
    public class ItemInventory
    { 
        private List<Item> inventory = new List<Item>();
        public List<Item> Inventory => inventory;
    
        public void AddItem(Item item)
        {
            inventory.Add(item);
        }
        
        public void RemoveItem(Item item)
        {
            inventory.Remove(item);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("=============================================================================================================================");
            Console.WriteLine("- Items Status -");
            foreach (Item item in inventory)
            {
                Console.WriteLine($"Weapon > {item.Name} | Atk : {item.Atk} | AtkSp : {item.AtkSpeed} | Def : {item.Def} | CritChance : {item.CritChance} | Evade : {item.Evade} | Elemental Type {item.WeaponType}");
            }
            Console.WriteLine("=============================================================================================================================");
        }
    }
}