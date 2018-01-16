using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InMemoryBrokers;
using NUnit.Framework;
using Poco;
using Moq;
using Effort;
using Effort.DataLoaders;
using Effort.Provider;


namespace UnitTests
{   [TestFixture]
    public class BrokerTest
    {
        // variables for state tests
        TradingPlatformContext context;
        InMemoryBrokerRepository repository;
        //Trade testTrade;
        //BTUser testUser;
        broker testBroker;

        // Variables for behavioural tests
        Mock<TradingPlatformContext> mockContext;
        //Mock<DbSet<broker>> mockSet;
        InMemoryBrokerRepository repositoryForMock;

        [Test]
        public void Test_GetAllBrokers_ReturnsAListOfLengthZero_WhenItHasHadNoBroker()
        {
            //test code
            //Arrange
            //broker brokers = new broker();
            List<broker> allBrokers = new List<broker>();
            allBrokers.Add(new broker
            {
                broker_id = 1,
                first_name = "Grace",
                last_name = "Akhibi"
            });
            Mock<IBrokerRepository> mockRepository = new Mock<IBrokerRepository>();
            mockRepository.Setup(b => b.GetAllBrokers()).Returns(allBrokers);
            var brokerController = new InMemoryBrokerRepository();
            brokerController.GetAllBrokers();
            brokerController.Should().NotBeNull();
            //Act
            // List<broker> brokersInMemory = brokers.GetAllBrokers();

            //Assert
            //Assert.AreEqual(0, brokersInMemory.Count);
        }

        //[Test]
        //public void TestInsert()
        //{
        //    //Arrange
        //    var commandMock = new Mock<broker>();
        //    commandMock
        //        .Setup(m => m.GetAllBrokers())
        //        .Verifiable();

        //    var connectionMock = new Mock<IDbConnection>();
        //    connectionMock
        //        .Setup(m => m.CreateCommand())
        //        .Returns(commandMock.Object);

        //    var connectionFactoryMock = new Mock<IDbConnectionFactory>();
        //    connectionFactoryMock
        //        .Setup(m => m.CreateConnection())
        //        .Returns(connectionMock.Object);

        //    var sut = new MyDataAccessClass(connectionFactoryMock.Object);
        //    var firstName = "John";
        //    var lastName = "Doe";

        //    //Act
        //    sut.Insert(firstName, lastName);

        //    //Assert
        //    commandMock.Verify();
        //}
    }
}
