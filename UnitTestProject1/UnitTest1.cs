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

        /// <summary>
        /// Check Email - ID
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]
        [DataRow("rani.gupta@gmail.com")]
        [DataRow("rani@gmail.com")]
        [DataRow("rani.gp@gmail.com")]
        [DataRow("rani-100@gmail.com")]
        [DataRow("rani@gmail.net")]
        [DataRow("rani.gp@gmail.com.com")]
        [DataRow("rani@1.com")]
        public void GivenEmail_CheckIfValid(string email)
        {
            //Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.Email(email);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("Ran$ig@gmail.com")]
        [DataRow("Ran$i@g@gmail.com")]
        [DataRow("ranig")]
        [DataRow("rani@.com.com")]
        [DataRow("rani%gp@gmail.com")]
        [DataRow("rani@gmail.com.bi.ku")]
        [DataRow("rani.gp@gmail.com.6t")]
        [DataRow("rani()*@gmail.com")]
        [DataRow(".rani@gmail.com")]
        [DataRow("rani..gp@gmail.com")]
        public void GivenEmail_CheckIfNotValid(string email)
        {
            //Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.Email(email);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("91 9098638600")]
        public void GivenMobile_CheckIfValid(string mobile)
        {
            //Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.Mobile(mobile);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("9099096400")]
        public void GivenMobile_CheckIfNotValid(string mobile)
        {
            //Arrange
            UserValidation validation = new UserValidation();

            //Act
            bool result = validation.Mobile(mobile);

            //Assert
            Assert.IsFalse(result);
        }


    }
}






