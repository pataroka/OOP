namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int DefaultGriffinAttack = 8;
        private const int DefaultGriffinDefense = 8;
        private const int DefaultGriffinHealth = 25;
        private const decimal DefaultGriffinDamage = 4.5m;
        private const int GriffinDoubleDefenseWhenDefendingRounds = 5;
        private const int GriffinAddDefenseWhenSkipPoints = 3;

        public Griffin()
            : base(DefaultGriffinAttack, DefaultGriffinDefense, DefaultGriffinHealth, DefaultGriffinDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(GriffinDoubleDefenseWhenDefendingRounds));
            this.AddSpecialty(new AddDefenseWhenSkip(GriffinAddDefenseWhenSkipPoints));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        } 
    }
}