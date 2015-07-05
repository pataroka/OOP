namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int DefaultAncientBehemothAttack = 19;
        private const int DefaultAncientBehemothDefense = 19;
        private const int DefaultAncientBehemothHealth = 300;
        private const decimal DefaultAncientBehemothDamage = 40;
        private const int BehemothEnemyDefenseReductionPercentage = 80;
        private const int BehemothDoubleDefenseWhenDefendingRounds = 5;

        public AncientBehemoth()
            : base(DefaultAncientBehemothAttack, DefaultAncientBehemothDefense, DefaultAncientBehemothHealth, DefaultAncientBehemothDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(BehemothEnemyDefenseReductionPercentage));
            this.AddSpecialty(new DoubleDefenseWhenDefending(BehemothDoubleDefenseWhenDefendingRounds));
        } 
    }
}