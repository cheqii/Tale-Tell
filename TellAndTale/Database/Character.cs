namespace TellAndTale
{
    public abstract class Character : Data
    {
        #region -Declare Variables-

        private bool life;
        public bool Life
        {
            get => life;
            set => life = value;
        }

        private ElementalType characterType;
        public ElementalType CharacterType
        {
            get => characterType;
            set => characterType = value;
        }

        #endregion

        #region Methods
        

        #endregion
    }
}