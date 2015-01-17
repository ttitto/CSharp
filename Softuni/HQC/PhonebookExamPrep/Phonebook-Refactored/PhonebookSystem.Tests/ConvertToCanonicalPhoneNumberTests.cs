namespace PhonebookSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConvertToCanonicalPhoneNumberTests
    {
        [TestMethod]
        public void PhoneNumberInCanonicalFormShouldntBeChanged()
        {
            var actual = PhonebookApp.ConverToCanonicalPhoneNumber("+359899777235");

            Assert.AreEqual("+359899777235", actual);
        }

        [TestMethod]
        public void PhoneNumberWithInsideSpaces()
        {
            var actual = PhonebookApp.ConverToCanonicalPhoneNumber("0899 777 235");

            Assert.AreEqual("+359899777235", actual);
        }

        [TestMethod]
        public void PhoneNumberWithInsideSlashAndSpaces()
        {
            var actual = PhonebookApp.ConverToCanonicalPhoneNumber("02 / 981 11 11");

            Assert.AreEqual("+35929811111", actual);
        }

        [TestMethod]
        public void PhoneNumberWithParenthesis()
        {
            var actual = PhonebookApp.ConverToCanonicalPhoneNumber("(+359) 899777236");

            Assert.AreEqual("+359899777236", actual);
        }

        [TestMethod]
        public void PhoneNumberWithBeginningParenthesisAndDashes()
        {
            var actual = PhonebookApp.ConverToCanonicalPhoneNumber("(+359) 899-777-236");

            Assert.AreEqual("+359899777236", actual);
        }

        [TestMethod]
        public void PhoneNumberWithCityCodeParenthesisDashesAndBeginningZeroes()
        {
            var actual = PhonebookApp.ConverToCanonicalPhoneNumber("00359 (888) 41-80-12");

            Assert.AreEqual("+359888418012", actual);
        }
    }
}
