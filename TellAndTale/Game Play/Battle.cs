using System;
using System.Collections.Generic;

namespace TellAndTale
{
    public class Battle
    {
        
        public void BattleStart(Ally a, List<Character> allies, ItemInventory i, Item item, List<Item> itemsList)
        {
            a.DisplayAllies();
            i.DisplayInventory();
            
            Console.WriteLine("Before the battle, you have to attach items with your allies to make them stronger and ready to fight with enemies.");
            Console.WriteLine("You can attach items to allies by typing the name of the item and the name of the ally.");
            item.AttachItem(allies, itemsList);
        } // end of BattleStart
    }

}