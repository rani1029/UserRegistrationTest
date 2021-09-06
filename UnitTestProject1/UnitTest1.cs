using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserregistraionMstest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Rani")]
        public void GivenFirstName_CheckIfValid(string name)
        {
            // Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.FirstName(name);

            //Assert
            Assert.IsTrue(result);

        }
    }
}
