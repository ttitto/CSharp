﻿namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;

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

        public void Accept(Func<ICarVisitor > visitorFactory)
        {
            EngineStructure structure = new EngineStructure(this.power, this.cylinderVolume);
            EngineStatus status = new EngineStatus(this.temperitureC, 0);
            visitorFactory().VisitEngine(structure, status);
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
