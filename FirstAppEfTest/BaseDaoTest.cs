using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
namespace FirstAppEfTest
{
    [TestClass]
    public class BaseDaoTest
    {

        // Mocks para IRepository y IMapper
        private Mock<IRepository<YourEntity>> repositoryMock;
        private Mock<IMapper> mapperMock;

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
