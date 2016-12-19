namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public Engine Engine { get; private set; }

        public Car(string make, string model, Engine engine)
        {
            this.Make = make;
            this.Model = model;
            this.Engine = engine;
        }
    }
}
