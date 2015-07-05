namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;
    using WinterIsComing.Models.Units;

    public class IceGiantCombatHandler : CombatHandler
    {
        private const int IceGiantTargetModifier = 150;

        public IceGiantCombatHandler(IUnit unit)
            : base(unit)
        {
            this.SpellIndex = 0;
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var caster = (Unit)this.Unit;

            if (caster.HealthPoints <= IceGiantTargetModifier)
            {
                var target = new[] { candidateTargets.FirstOrDefault() };
                return target;
            }

            return candidateTargets;
        }

        public override ISpell GenerateAttack()
        {
            var caster = (Unit)this.Unit;
            var spell = caster.GetSpell(this.SpellIndex);
            if (caster.EnergyPoints - spell.EnergyCost < 0)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast {1}", caster.Name, spell.GetType().Name));
            }

            caster.EnergyPoints -= spell.EnergyCost;
            caster.AttackPoints += 5;

            return spell;
        }
    }
}