using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Test";
            customer.LastName = "Last";

            string expected = "Last,Test";
            // Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNameEmptyTestInValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Last";

            string expected = "Last";
            // Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastNameEmptyTestInValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "First";

            string expected = "First";
            // Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
