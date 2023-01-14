using System;
using System.Collections.Generic;
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
            characters.Add(new BigFrog());
            characters.Add(new IronBunny());
            characters.Add(new WitchCat());

            while (items[0] == null && items[1] == null && items[2] == null)
            {
                Console.WriteLine("You have no items to attach");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine($"Please enter the item you want to attach to {characters[i].Name}");
                string nameItems = Console.ReadLine()?.ToLower();
                if (items[0] == null)
                {
                    switch (nameItems)
                    {
                        case "sword":
                            items[0] = new Sword();
                            i++;
                            break;
                        case "wand":
                            items[0] = new Wand();
                            i++;
                            break;
                        case "axe":
                            items[0] = new Axe();
                            i++;
                            break;
                    }
                }
                else if (items[1] == null)
                {
                    switch (nameItems)
                    {
                        case "sword":
                            if(items[1] == items[0])
                            {
                                Console.WriteLine($"You already have this {items[0].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                items[1] = new Sword();
                                i++;
                            }
                            break;
                        case  "wand":
                            if(items[1] == items[0])
                            {
                                Console.WriteLine($"You already have this {items[0].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                items[1] = new Wand();
                                i++;
                            }
                            break;
                        case "axe":
                            if(items[1] == items[0])
                            {
                                Console.WriteLine($"You already have this {items[0].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                items[1] = new Axe();
                                i++;
                            }
                            break;
                    }
                }
                else if (items[2] == null)
                {
                    switch (nameItems)
                    {
                        case "sword":
                            if(items[2] == items[0])
                            {
                                Console.WriteLine($"You already have this {items[0].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if(items[2] == items[1])
                            {
                                Console.WriteLine($"You already have this {items[1].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                items[2] = new Sword();
                                i++;
                            }
                            break;
                        case "wand":
                            if(items[2] == items[0])
                            {
                                Console.WriteLine($"You already have this {items[0].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if(items[2] == items[1])
                            {
                                Console.WriteLine($"You already have this {items[1].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                items[2] = new Wand();
                                i++;
                            }
                            break;
                        case "axe":
                            if(items[2] == items[0])
                            {
                                Console.WriteLine($"You already have this {items[0].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if(items[2] == items[1])
                            {
                                Console.WriteLine($"You already have this {items[1].Name}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                items[2] = new Axe();
                                i++;
                            }
                            break;
                    }
                }
            }
        }

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
        }

       
    }
}