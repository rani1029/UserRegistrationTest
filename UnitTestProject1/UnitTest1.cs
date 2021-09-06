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

        [TestMethod]
        [DataRow("rani")]
        public void GivenFirstName_CheckIfInValid(string name)
        {
            // Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.FirstName(name);

            //Assert
            Assert.IsFalse(result);


        }
        [TestMethod]
        [DataRow("Gupta")]
        public void GivenLastName_CheckIfValid(string name)
        {
            //Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.LastName(name);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [DataRow("gupta")]
        public void GivenLastName_CheckIfInValid(string name)
        {
            //Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.LastName(name);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
