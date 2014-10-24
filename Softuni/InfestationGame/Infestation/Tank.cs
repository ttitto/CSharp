namespace Infestation
{
    public class Tank : Unit
    {
        public Tank(
            string id,
            UnitClassification unitType = UnitClassification.Mechanical,
            int health = 20,
            int power = 25,
            int aggression = 25)
            : base(id, unitType, health, power, aggression)
        {
        }
    }
}