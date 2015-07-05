namespace WinterIsComing.Models.Units
{
    using WinterIsComing.Models.CombatHandlers;
    using WinterIsComing.Models.Spells;

    public class Mage : Unit
    {
        private const int MageRange = 2;

        private const int MageAttackPoints = 80;

        private const int MageDefensePoints = 40;

        private const int MageHealthPoints = 80;

        private const int MageEnergyPoints = 120;

        public Mage(string name, int x, int y)
            : base(UnitType.Mage, name, x, y, MageRange, MageAttackPoints, MageDefensePoints, MageHealthPoints, MageEnergyPoints)
        {
            this.AddSpell(new FireBreath(this));
            this.AddSpell(new Blizzard(this));
            this.CombatHandler = new MageCombatHandler(this);
        } 
    }
}