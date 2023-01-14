using System.Linq;

namespace TellAndTale
{
    public class Enemy : Data
    {
        #region -Declare Variables-

        private bool life;

        public bool Life
        {
            get => life;
            set => life = value;
        }

        private ElementalType enemyType;

        public ElementalType EnemyType
        {
            get => enemyType;
            set => enemyType = value;
        }

        #endregion
    }
}