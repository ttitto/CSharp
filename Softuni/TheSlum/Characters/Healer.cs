namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum;
    using TheSlum.Interfaces;
    using TheSlum.Characters;
    using TheSlum.Items;

    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, int healthPoints, int defensePoints, int healingPoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets = from target in targetsList
                          where target.IsAlive && target.Team == this.Team && target != this
                          orderby target.HealthPoints
                          select target;

            return targets.FirstOrDefault() as Character;
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


        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}