namespace VisitorPatternAndEncapsulation.CarShop
{
    public class EngineStatus
    {
        public float TemperatureC { get; private set; }
        public float OilPressure { get; private set; }

        public EngineStatus(float temperatureC, float oilPressure)
        {
            this.TemperatureC = temperatureC;
            this.OilPressure = oilPressure;
        }
    }
}
