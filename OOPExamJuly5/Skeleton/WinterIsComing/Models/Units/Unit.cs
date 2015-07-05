namespace WinterIsComing.Models.Units
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;

    public abstract class Unit : IUnit
    {
        protected internal readonly IList<ISpell> Spells;

        private const int MaxFieldSize = 4;
        private const int MinFieldSize = 0;

        private int x;
        private int y;
        private string name;
        private int range;

        public Unit(UnitType type, string name, int x, int y, int range, int attackPoints, int defensePoints, int healthPoints, int energyPoints)
        {
            this.Type = type;
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Range = range;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.EnergyPoints = energyPoints;
            this.Spells = new List<ISpell>();
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value < MinFieldSize || value > MaxFieldSize)
                {
                    throw new InvalidPositionException(string.Format("X must be a value between {0} and {1}", MinFieldSize, MaxFieldSize));
                }

                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                if (value < MinFieldSize || value > MaxFieldSize)
                {
                    throw new InvalidPositionException(string.Format("Y must be a value between {0} and {1}", MinFieldSize, MaxFieldSize));
                }

                this.y = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be an empty string.");
                }

                this.name = value;
            }
        }

        public int Range
        {
            get
            {
                return this.range;
            }

            private set
            {
                if (value < 1 || value > MaxFieldSize)
                {
                    throw new ArgumentOutOfRangeException("range", string.Format("Range must be a number between 1 and {0}", MaxFieldSize));
                }

                this.range = value;
            }
        }

        public int AttackPoints { get; set; }

        public int HealthPoints { get; set; }

        public int DefensePoints { get; set; }

        public int EnergyPoints { get; set; }

        public ICombatHandler CombatHandler { get; set; }

        public UnitType Type { get; private set; }

        public void AddSpell(ISpell spell)
        {
            this.Spells.Add(spell);
        }

        public ISpell GetSpell(int index)
        {
            return this.Spells[index];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.HealthPoints > 0)
            {
                sb.AppendFormat(">{0} - {1} at ({2},{3}){4}", this.Name, this.Type, this.X, this.Y, Environment.NewLine);
                sb.AppendFormat("-Health points = {0}{1}", this.HealthPoints, Environment.NewLine);
                sb.AppendFormat("-Attack points = {0}{1}", this.AttackPoints, Environment.NewLine);
                sb.AppendFormat("-Defense points = {0}{1}", this.DefensePoints, Environment.NewLine);
                sb.AppendFormat("-Energy points = {0}{1}", this.EnergyPoints, Environment.NewLine);
                sb.AppendFormat("-Range = {0}", this.Range);
            }
            else
            {
                sb.AppendFormat(">{0} - {1} at ({2},{3}){4}", this.Name, this.Type, this.X, this.Y, Environment.NewLine);
                sb.Append("(Dead)");
            }

            return sb.ToString();
        }
    }
}