using System;
using System.Collections.Generic;
using TellAndTale;
using TellAndTale.Items;

namespace TellAndTale
{
    public class Item : Data
    {
        private ElementalType weaponType;

        public ElementalType WeaponType
        {
            get => weaponType;
            set => weaponType = value;
        }

        public void AttachItem(List <Character> characters, List <Item> items)
        {
            //TODO: Attach item to character
            int i = 0;
            bool itemCheck = true;
            characters.Add(new BigFrog());
            characters.Add(new IronBunny());
            characters.Add(new WitchCat());

            Console.WriteLine("You have no items to attach");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine($"Please enter the item you want to attach to {characters[i].Name}");
            string nameItem = Console.ReadLine()?.ToLower();

            while (itemCheck)
            {
                
            }
            
            {
                
            }
            // while (itemCheck)
            // {
            //     Console.WriteLine("You have no items to attach");
            //     Console.WriteLine("Press any key to continue");
            //     Console.ReadKey();
            //
            //     Console.Clear();
            //     Console.WriteLine($"Please enter the item you want to attach to {characters[i].Name}");
            //     string nameItem = Console.ReadLine()?.ToLower();
            //     
            //     
            // }
            
            
        } // emd of AttachItem

        public void EquipItem(List<Character> characters, List<Item> items)
        {
            // if (characters[0].Name == "Big Frog")
            // {
            //     characters[0].Atk += items[0].Atk;
            //     characters[0].AtkSpeed += items[0].AtkSpeed;
            //     characters[0].Def += items[0].Def;
            //     characters[0].CritChance += items[0].CritChance;
            //     characters[0].Evade += items[0].Evade;
            // }
            
            for (int i = 0; i < characters.Count; i++)
            {
                characters[i].Atk += items[i].Atk;
                characters[i].AtkSpeed += items[i].AtkSpeed;
                characters[i].Def += items[i].Def;
                characters[i].CritChance += items[i].CritChance;
                characters[i].Evade += items[i].Evade;
            }
        } // end of EquipItem
    }
}