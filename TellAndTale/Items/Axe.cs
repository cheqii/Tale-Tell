namespace TellAndTale.Items
{
    public class Axe : Item
    {
        public Axe()
        {
            base.Name = "axe";
            base.Atk = 35;
            base.AtkSpeed = 10;
            base.Def = 0;
            base.CritChance = 15;
            base.Evade = 0;
            base.WeaponType = ElementalType.Water;
        }
    }
}