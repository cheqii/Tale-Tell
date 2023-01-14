using System.Collections.Generic;
using TellAndTale.Items;

namespace TellAndTale
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Character bigFrog = new BigFrog();
            Character ironBunny = new IronBunny();
            Character witchCat = new WitchCat();
            
            Ally ally = new Ally();

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
            ally.DisplayAllies();
            
            // Starter items in inventory
            inventory.AddItem(sword);
            inventory.AddItem(wand);
            inventory.AddItem(axe);
            inventory.AddItem(dagger);
            
            // Display items in inventory
            inventory.DisplayInventory();
            
            //sword.AttachItem(new List<Character>(), new List<Item>());
        }
    }
}