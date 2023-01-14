namespace TellAndTale.Items
{
    public class Sword : Item
    {
        public Sword()
        {
            base.Name = "sword";
            base.Atk = 15;
            base.AtkSpeed = 15;
            base.Def = 0;
            base.CritChance = 10;
            base.Evade = 0;
            base.WeaponType = ElementalType.Fire;
        }
    }
}