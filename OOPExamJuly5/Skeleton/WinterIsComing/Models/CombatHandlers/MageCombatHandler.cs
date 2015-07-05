namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;
    using WinterIsComing.Models.Units;

    public class MageCombatHandler : CombatHandler
    {
        private const int MageMaxNumberOfTargets = 3;

        public MageCombatHandler(IUnit unit)
            : base(unit)
        {
            this.SpellIndex = 0;
        }

        public new int SpellIndex
        {
            get
            {
                return base.SpellIndex;
            }

            set
            {
                var owner = (Unit)this.Unit;
                if (base.SpellIndex + value >= owner.Spells.Count)
                {
                    base.SpellIndex = 0;
                }
                else
                {
                    base.SpellIndex += value;
                }
            }
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            IEnumerable<IUnit> result;

            IEnumerable<IUnit> targets = candidateTargets.OrderByDescending(t => t.HealthPoints).ThenBy(t => t.Name);

            if (targets.Count() > MageMaxNumberOfTargets)
            {
                result = targets.Take(3);
            }
            else
            {
                result = targets;
            }

            return result;
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
            this.SpellIndex++;

            return spell;
        }
    }
}