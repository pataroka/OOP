namespace WinterIsComing.Models.Spells
{
    using WinterIsComing.Contracts;

    public class Cleave : Spell
    {
        private const int CleaveEnergyCost = 15;

        private const int CleaveDamageModifier = 80;

        private const int CleaveEnergyModifier = 50;
        
        public Cleave(IUnit ownerUnit)
            : base(CleaveEnergyCost, UnitType.Warrior, ownerUnit)
        {
        }

        public override int Damage
        {
            get
            {
                if (this.OwnerUnit.HealthPoints <= CleaveDamageModifier)
                {
                    return base.Damage + (this.OwnerUnit.HealthPoints * 2);
                }

                return base.Damage;
            }
        }

        public override int EnergyCost 
        {
            get
            {
                if (this.OwnerUnit.HealthPoints <= CleaveEnergyModifier)
                {
                    return 0;
                }

                return base.EnergyCost;
            }
        }
    }
}