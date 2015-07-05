namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;
    using WinterIsComing.Models.Units;

    public abstract class CombatHandler : ICombatHandler
    {
        public CombatHandler(IUnit unit)
        {
            this.Unit = unit;
        }

        public int SpellIndex { get; set; }

        public IUnit Unit { get; set; }

        public abstract IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets);

        public virtual ISpell GenerateAttack()
        {
            var caster = (Unit)this.Unit;
            var spell = caster.GetSpell(this.SpellIndex);
            if (caster.EnergyPoints - spell.EnergyCost < 0)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast {1}", caster.Name, spell.GetType().Name));
            }

            caster.EnergyPoints -= spell.EnergyCost;
            return spell;
        }
    }
}