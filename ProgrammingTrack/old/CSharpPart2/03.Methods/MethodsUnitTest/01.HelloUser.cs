using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.HelloUser;

namespace MethodsUnitTest
{
    [TestClass]
    public class UnitTestHelloUser
    {
        [TestMethod]
        public void TestMethodPesho()
        {

            string expectedResult = "Hello Pesho!";
            string actualResult = HelloUser.Hello("Pesho");
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethodGosho()
        {

            string expectedResult = "Hello Gosho!";
            string actualResult = HelloUser.Hello("Gosho");
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethodPenka()
        {

            string expectedResult = "Hello Penka!";
            string actualResult = HelloUser.Hello("Penka");
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
