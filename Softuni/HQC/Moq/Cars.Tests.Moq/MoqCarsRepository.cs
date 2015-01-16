namespace Cars.Tests.Mocking
{
    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MoqCarsRepository
    {
        public MoqCarsRepository()
        {
            this.PopulateFakeData();
            this.ArrangeCarsRepositoryMock();
        }

        public ICarsRepository CarsData { get; protected set; }

        public ICollection<Car> FakeCarsCollection { get; protected set; }

        private void ArrangeCarsRepositoryMock()
        {
            var mockedCarsData = new Mock<ICarsRepository>();
            mockedCarsData.Setup(r => r.All()).Returns(this.FakeCarsCollection);
            mockedCarsData.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsData.Setup(r => r.GetById(It.Is<int>(n => n == 12))).Verifiable();
            mockedCarsData.Setup(r => r.GetById(It.Is<int>(n => n != 12))).Returns(this.FakeCarsCollection.First());
            mockedCarsData.Setup(r => r.Search(It.IsAny<string>()))
                .Returns(this.FakeCarsCollection.Where(c => c.Make == "BMW").ToList());
            this.CarsData = mockedCarsData.Object;
        }

        private void PopulateFakeData()
        {
            this.FakeCarsCollection = new List<Car>()
            {
                new Car { Id = 1, Make = "Audi", Model = "A4", Year = 2005 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 },
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 },
                new Car { Id = 4, Make = "Opel", Model = "Astra", Year = 2010 },
            };
        }
    }
}
