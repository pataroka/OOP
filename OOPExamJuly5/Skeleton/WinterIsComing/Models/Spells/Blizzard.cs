namespace WinterIsComing.Models.Spells
{
    using WinterIsComing.Contracts;

    public class Blizzard : Spell
    {
        private const int BlizzardEnergyCost = 40;

        public Blizzard(IUnit ownerUnit)
            : base(BlizzardEnergyCost, UnitType.Mage, ownerUnit)
        {
        }

        public override int Damage
        {
            get
            {
                return base.Damage * 2;
            }
        }
    }
}