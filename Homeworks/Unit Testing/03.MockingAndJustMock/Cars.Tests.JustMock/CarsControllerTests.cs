namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using Moq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using System.Linq;

    [TestClass]
    public class CarsControllerTests
    {
        [TestMethod]
        public void Index_ShouldReturnAllCars()
        {
            var controller = new CarsController(FakeDB.GetFakeRepository());

            var result = controller.Index().Model;

            Assert.AreEqual(FakeDB.fakeCarsDB, result);
        }

        [TestMethod]
        public void Add_PassedNull_ShouldThrows()
        {
            var controller = new CarsController(FakeDB.GetFakeRepository());

            Assert.ThrowsException<ArgumentNullException>(() => controller.Add(null));
        }

        [TestMethod]
        public void Add_PassedMakeNull_ShouldThrows()
        {
            var controller = new CarsController(FakeDB.GetFakeRepository());

            var car = new Car()
            {
                Id = 8,
                Make = null,
                Model = "Record",
                Year = 1999
            };

            Assert.ThrowsException<ArgumentNullException>(() => controller.Add(car));
        }

        [TestMethod]
        public void Add_PassedModelNull_ShouldThrows()
        {
            var controller = new CarsController(FakeDB.GetFakeRepository());

            var car = new Car()
            {
                Id = 8,
                Make = "Opel",
                Model = null,
                Year = 1999
            };

            Assert.ThrowsException<ArgumentNullException>(() => controller.Add(car));
        }

        [TestMethod]
        public void Search_CorrectData_ShouldreturnView()
        {
            var controller = new CarsController(FakeDB.GetFakeRepository());

            Assert.IsInstanceOfType(controller.Search(It.IsAny<string>()), typeof(IView));
        }

        [TestMethod]
        public void Sort__ByYear_ShouldCallSortByYear()
        {
            var fakeRepo = new Mock<ICarsRepository>();
            fakeRepo.Setup(x => x.SortedByYear()).Verifiable();

            var controller = new CarsController(fakeRepo.Object);
            controller.Sort("year");

            fakeRepo.Verify(x => x.SortedByYear(), Times.Once);
        }

        [TestMethod]
        public void Sort__ByMake_ShouldCallSortByMake()
        {
            var fakeRepo = new Mock<ICarsRepository>();
            fakeRepo.Setup(x => x.SortedByMake()).Verifiable();

            var controller = new CarsController(fakeRepo.Object);
            controller.Sort("make");

            fakeRepo.Verify(x => x.SortedByMake(), Times.Once);
        }

        [TestMethod]
        public void Sort_ValidSearchYear_ShouldReturnView()
        {
            var search = "year";
            var collection = new List<Car>();

            var fakeRepo = new Mock<ICarsRepository>();

            fakeRepo.Setup(x => x.SortedByYear()).Returns(collection);

            var controller = new CarsController(fakeRepo.Object);

            Assert.IsInstanceOfType(controller.Sort(search), typeof(IView));
        }

        [TestMethod]
        public void Sort_ValidSearchMake_ShouldReturnView()
        {
            var search = "make";
            var collection = new List<Car>();

            var fakeRepo = new Mock<ICarsRepository>();

            fakeRepo.Setup(x => x.SortedByMake()).Returns(collection);

            var controller = new CarsController(fakeRepo.Object);

            Assert.IsInstanceOfType(controller.Sort(search), typeof(IView));
        }
    }
}
