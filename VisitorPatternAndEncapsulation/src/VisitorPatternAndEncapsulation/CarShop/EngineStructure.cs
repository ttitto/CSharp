namespace VisitorPatternAndEncapsulation.CarShop
{
    public class EngineStructure
    {
        public float Power { get; private set; }
        public float CylinderVolume { get; private set; }

        public EngineStructure(float power, float cylinderVolume)
        {
            this.Power = power;
            this.CylinderVolume = cylinderVolume;
        }
    }
}
