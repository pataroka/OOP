namespace WinterIsComing.Models.Spells
{
    using WinterIsComing.Contracts;

    public class Stomp : Spell
    {
        private const int StompEnergyCost = 10;

        public Stomp(IUnit ownerUnit)
            : base(StompEnergyCost, UnitType.IceGiant, ownerUnit)
        {
        }

        public override int Damage
        {
            get
            {
                this.OwnerUnit.AttackPoints += 5;
                return this.OwnerUnit.AttackPoints - 5;
            }
        }
    }
}