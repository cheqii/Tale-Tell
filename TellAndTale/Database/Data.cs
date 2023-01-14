namespace TellAndTale
{
    public class Data
    {
        #region -Declare Variables-

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private double hp;
        public double Hp
        {
            get => hp;
            set => hp = value;
        }

        private double atk;
        public double Atk
        {
            get => atk;
            set => atk = value;
        }

        private double atkSpeed;
        public double AtkSpeed
        {
            get => atkSpeed;
            set => atkSpeed = value;
        }

        private double def;
        public double Def
        {
            get => def;
            set => def = value;
        }

        private int critChance;
        public int CritChance;

        private int evade;
        public int Evade
        {
            get => evade;
            set => evade = value;
        }

        #endregion

        // Constructor

        protected Data() {}
        public Data(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.atkSpeed = atkSpeed;
            this.def = def;
            this.critChance = critChance;
            this.evade = evade;
        }
    }
}