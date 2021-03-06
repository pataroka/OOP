﻿namespace TheSlum.Items
{
    internal abstract class Item : GameObject
    {
        protected Item(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id)
        {
            this.HealthEffect = healthEffect;
            this.DefenseEffect = defenseEffect;
            this.AttackEffect = attackEffect;
        }

        public int HealthEffect { get; set; }

        public int DefenseEffect { get; set; }

        public int AttackEffect { get; set; }
    }
}