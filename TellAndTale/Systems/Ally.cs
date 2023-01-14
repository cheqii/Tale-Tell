using System.Collections.Generic;
using System;

namespace TellAndTale
{
    public class Ally
    {
        private List<Character> allies = new List<Character>();
        public List<Character> Allies => allies;
        
        public void AddAlly(Character ally)
        {
            allies.Add(ally);
        }
        
        public void RemoveAlly(Character ally)
        {
            allies.Remove(ally);
        }

        public void DisplayAllies()
        {
            Console.WriteLine("=============================================================================================================================");
            Console.WriteLine("- Allies Status -");
            foreach (var ally in allies)
            {
                Console.WriteLine($"Character > {ally.Name} | Hp : {ally.Hp} | Atk : {ally.Atk} | AtkSp : {ally.AtkSpeed} | Def : {ally.Def} | CritChance : {ally.CritChance} | Evade : {ally.Evade} | Elemental Type {ally.CharacterType}");
            }
            Console.WriteLine("=============================================================================================================================");
        }
    }
}