namespace TellAndTale
{
    public class IronMagmaP : Enemy
    {
        public IronMagmaP()
        {
            base.Name = "Pigma";
            base.Hp = 700;
            base.Atk = 65;
            base.AtkSpeed = 20;
            base.Def = 50;
            base.Evade = 5;
            base.CritChance = 20;
            base.Life = true;
            base.EnemyType = ElementalType.Fire;
        }
    }
}