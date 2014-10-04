namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;
    using TheSlum.Characters;
    using TheSlum.Items;
    using TheSlum;

    public class Mage : Character, IAttack
    {
        public Mage(string id, int x, int y, int healthPoints, int defensePoints, int attackPoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.LastOrDefault(ch => (ch.Team != this.Team && ch.IsAlive));
            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }
        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}