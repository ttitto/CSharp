namespace Cars.Tests.Mocking
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using System.Collections.Generic;
    using System.Collections;

    [TestClass]
    public class CarsControllerTests
    {
        private ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new MoqCarsRepository())
        {
        }

        public CarsControllerTests(MoqCarsRepository carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void InstantiateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var result = (ICollection<Car>)this.controller.Index().Model;
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowArgumentExceptionIfParameterNull()
        {
            this.controller.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            Car car = new Car();
            car.Model = "19";
            this.controller.Add(car);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            Car car = new Car();
            car.Make = "Renault";
            this.controller.Add(car);
        }

        [TestMethod]
        public void AddShouldReturnDetail()
        {
            Car car = new Car()
            {
                Id = 15,
                Make = "Audi",
                Model = "A4",
                Year = 2005
            };

            var view = this.controller.Add(car);
            var model = (Car)view.Model;

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A4", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsShouldThrowArgumentNullExceptionIfIdDoesntExists()
        {
            this.controller.Details(12);
        }

        [TestMethod]
        public void SearchShouldReturnICollectionOfCars()
        {
            string condition = " ";
            var view = this.controller.Search(condition);
            var model = (ICollection)view.Model;
            var expected = (ICollection)new List<Car>(){
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 },
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 }
            };


            CollectionAssert.Equals(expected, model);
        }
    }
}
