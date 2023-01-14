namespace TellAndTale
{
    public class IronBunny : Character
    {
        public IronBunny()
        {
            base.Name = "Iron Bunny";
            base.Hp = 300;
            base.Atk = 25;
            base.AtkSpeed = 10;
            base.Def = 50;
            base.Evade = 15;
            base.CritChance = 45;
            base.Life = true;
            base.CharacterType = ElementalType.Leaf;
        }
    }
}