using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCIApp;

namespace UnitTestProj
{
    [TestClass]
    public class ConverterLibrary_TU
    {
        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("13", 13)]
        [DataRow("-3", -3)]
        public void TestGetInt(string target, int expected)
        {
            //Arrange
            ConverterLibrary lib = new ConverterLibrary();

            //Act
            var tmp = lib.GetInt(target);

            //Assert
            Assert.AreEqual(expected, tmp);
        }
    }
}
