namespace WinterIsComing.Models.Spells
{
    using WinterIsComing.Contracts;

    public class FireBreath : Spell
    {
        private const int FireBreathEnergyCost = 30;

        public FireBreath(IUnit ownerUnit)
            : base(FireBreathEnergyCost, UnitType.Mage, ownerUnit)
        {
        }
    }
}