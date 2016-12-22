namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Seat
    {
        public string Name { get;private set; }
        public int Capacity { get;private set; }

        public Seat(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public static IEnumerable<Seat> FourSeatConfiguration {
            get
            {
                return new Seat[] {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1),
                    new Seat("Rear bench", 2)
                };
            }
        }
        
        public static IEnumerable<Seat> TwoSeatConfiguration
        {
            get
            {
                return new Seat[] {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1)
                };
            }
        }

        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
