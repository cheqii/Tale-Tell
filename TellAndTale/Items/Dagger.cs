namespace TellAndTale.Items
{
    public class Dagger : Item
    {
        public Dagger()
        {
            base.Name = "dagger";
            base.Atk = 10;
            base.AtkSpeed = 30;
            base.Def = 0;
            base.CritChance = 5;
            base.Evade = 15;
            base.WeaponType = ElementalType.Leaf;
        }
    }
}