namespace WinterIsComing.Models.Units
{
    using WinterIsComing.Models.CombatHandlers;
    using WinterIsComing.Models.Spells;

    public class Warrior : Unit
    {
        private const int WarriorRange = 1;

        private const int WarriorAttackPoints = 120;

        private const int WarriorDefensePoints = 70;

        private const int WarriorHealthPoints = 180;

        private const int WarriorEnergyPoints = 60;

        public Warrior(string name, int x, int y)
            : base(UnitType.Warrior, name, x, y, WarriorRange, WarriorAttackPoints, WarriorDefensePoints, WarriorHealthPoints, WarriorEnergyPoints)
        {
            this.AddSpell(new Cleave(this));
            this.CombatHandler = new WarriorCombatHandler(this);
        }
    }
}