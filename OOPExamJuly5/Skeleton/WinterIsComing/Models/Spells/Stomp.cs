namespace WinterIsComing.Models.Spells
{
    using WinterIsComing.Contracts;

    public class Stomp : Spell
    {
        private const int StompEnergyCost = 30;

        public Stomp(IUnit ownerUnit)
            : base(StompEnergyCost, UnitType.IceGiant, ownerUnit)
        {
        } 
    }
}