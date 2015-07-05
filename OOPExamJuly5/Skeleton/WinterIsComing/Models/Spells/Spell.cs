namespace WinterIsComing.Models.Spells
{
    using System.Runtime.CompilerServices;

    using WinterIsComing.Contracts;

    public class Spell : ISpell
    {
        public Spell(int energyCost, UnitType unitType, IUnit ownerUnit)
        {
            this.EnergyCost = energyCost;
            this.UnitType = unitType;
            this.OwnerUnit = ownerUnit;
            this.Damage = ownerUnit.AttackPoints;
        }

        public virtual int Damage { get; protected set; }

        public virtual int EnergyCost { get; private set; }

        public UnitType UnitType { get; set; }

        public IUnit OwnerUnit { get; set; }
    }
}