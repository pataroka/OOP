﻿namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class CyclopsKing : Creature
    {
        private const int DefaultCyclopsKingAttack = 17;
        private const int DefaultCyclopsKingDefense = 13;
        private const int DefaultCyclopsKingHealth = 70;
        private const decimal DefaultCyclopsKingDamage = 18;
        private const int CyclopsKingAddAttackWhenSkipPoints = 3;
        private const int CyclopsKingDoubleAttackWhenAttackingRounds = 4;
        private const int CyclopsKingDoubleDamageRounds = 1;

        public CyclopsKing()
            : base(DefaultCyclopsKingAttack, DefaultCyclopsKingDefense, DefaultCyclopsKingHealth, DefaultCyclopsKingDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(CyclopsKingAddAttackWhenSkipPoints));
            this.AddSpecialty(new DoubleAttackWhenAttacking(CyclopsKingDoubleAttackWhenAttackingRounds));
            this.AddSpecialty(new DoubleDamage(CyclopsKingDoubleDamageRounds));
        }  
    }
}