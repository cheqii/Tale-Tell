namespace TellAndTale
{
    public class BigFrog : Character
    {
        public BigFrog()
        {
            base.Name = "Big Frog";
            base.Hp = 250;
            base.Atk = 30;
            base.AtkSpeed = 30;
            base.Def = 30;
            base.Evade = 15;
            base.Life = true;
            base.CharacterType = ElementalType.Water;
        }
    }
}