namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using WinterIsComing.Contracts;

    public class WarriorCombatHandler : CombatHandler
    {
        public WarriorCombatHandler(IUnit unit)
            : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (!candidateTargets.Any())
            {
                return candidateTargets;
            }

            IEnumerable<IUnit> target = new[] { candidateTargets.OrderBy(t => t.HealthPoints).ThenBy(t => t.Name).FirstOrDefault() };
            return target;
        }
    }
}