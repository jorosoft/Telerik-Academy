namespace Cars.Tests.JustMock
{
    using Contracts;
    using Moq;
    using System.Collections.Generic;
    using Models;

    public class FakeDB
    {
        public static List<Car> fakeCarsDB = new List<Car>()
        {
            new Car() { Id = 1, Make = "VW", Model = "Passat", Year = 2006},
            new Car() { Id = 2, Make = "Ford", Model = "Escort", Year = 2010},
            new Car() { Id = 3, Make = "Toyota", Model = "Corolla", Year = 2016},
            new Car() { Id = 4, Make = "Lada", Model = "Kalina", Year = 2000},
            new Car() { Id = 5, Make = "Opel", Model = "Zafira", Year = 2007}
        };
        public static ICarsRepository GetFakeRepository()
        {
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.Add(It.IsAny<Car>())).Verifiable();
            mock.Setup(m => m.All()).Returns(fakeCarsDB);            
            return mock.Object;
        }
    }
}
