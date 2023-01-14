namespace TellAndTale
{
    public class NySlime : Enemy
    {
        public NySlime()
        {
            base.Name = "9Slime";
            base.Hp = 1000;
            base.Atk = 75;
            base.AtkSpeed = 20;
            base.Def = 60;
            base.Evade = 25;
            base.CritChance = 20;
            base.Life = true;
            base.EnemyType = ElementalType.Water;
        }
    }
}