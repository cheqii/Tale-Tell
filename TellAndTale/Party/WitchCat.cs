namespace TellAndTale
{
    public class WitchCat : Character
    {
        public WitchCat()
        {
            base.Name = "Witch Cat";
            base.Hp = 200;
            base.Atk = 45;
            base.AtkSpeed = 40;
            base.Def = 20;
            base.CritChance = 10;
            base.Evade = 15;
            base.Life = true;
            base.CharacterType = ElementalType.Fire;
        }
    }
}