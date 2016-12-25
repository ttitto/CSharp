namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;

    public class Seat
    {
        private string name;
        private int capacity;

        public Seat(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public static IEnumerable<Seat> FourSeatConfiguration
        {
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

        public void Accept(Func<ICarVisitor> visitorFactory)
        {
            visitorFactory().VisitSeat(this.name, this.capacity);
        }
    }
}
