namespace WinterIsComing.Models.Units
{
    using WinterIsComing.Models.CombatHandlers;
    using WinterIsComing.Models.Spells;

    public class IceGiant : Unit
    {
        private const int IceGiantRange = 1;

        private const int IceGiantAttackPoints = 150;

        private const int IceGiantDefensePoints = 60;

        private const int IceGiantHealthPoints = 300;

        private const int IceGiantEnergyPoints = 50;

        public IceGiant(string name, int x, int y)
            : base(UnitType.IceGiant, name, x, y, IceGiantRange, IceGiantAttackPoints, IceGiantDefensePoints, IceGiantHealthPoints, IceGiantEnergyPoints)
        {
            this.AddSpell(new Stomp(this));
            this.CombatHandler = new IceGiantCombatHandler(this);
        } 
    }
}