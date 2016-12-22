namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Engine
    {
        private const float WorkingTemperatureC = 90.0F;
        private float temperitureC;

        private float power;
        private float cylinderVolume;

        public Engine(float power, float cylinderVolume)
        {
            this.power = power;
            this.cylinderVolume = cylinderVolume;
        }

        public void Accept(ICarVisitor visitor)
        {
            visitor.VisitEngine(this.power, this.cylinderVolume, this.temperitureC);
        }

        public void Run(TimeSpan time)
        {
            TimeSpan heatingTime = this.GetHeatingTime();
            if (time > heatingTime)
            {
                this.temperitureC = WorkingTemperatureC;

            }
            else
            {
                double temperatureDelta = WorkingTemperatureC - this.temperitureC;
                double timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                this.temperitureC += (float)(temperatureDelta * timeRatio);
            }
        }

        private TimeSpan GetHeatingTime()
        {
            throw new NotImplementedException();
        }
    }
}
