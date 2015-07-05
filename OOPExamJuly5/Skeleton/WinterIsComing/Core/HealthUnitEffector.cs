namespace WinterIsComing.Core
{
    using System.Collections.Generic;
    using Contracts;

    public sealed class HealthUnitEffector : IUnitEffector
    {
        private const int GlobalHealthBonus = 50;

        public void ApplyEffect(IEnumerable<IUnit> units)
        {
            foreach (var unit in units)
            {
                unit.HealthPoints += GlobalHealthBonus;
            }
        }
    }
}
