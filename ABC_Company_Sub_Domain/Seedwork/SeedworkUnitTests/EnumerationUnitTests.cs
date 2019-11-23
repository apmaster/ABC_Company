using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seedwork;

namespace SeedworkUnitTests
{

    [TestClass]
    public class EnumerationUnitTests
    {

        [TestMethod]
        public void EnumeratedAmexTypeUnitTest()
        {
            //Arrange
            int testId;
            string Name = "";
            Boolean TestPass = false;
            //Act
            Name = UnitTestHarnessForCreditCardObjectTypes.Amex.Name;
            testId = UnitTestHarnessForCreditCardObjectTypes.Amex.Id;
            //Assert
            if((Name == "Amex")&&(testId == 1))
            {
                TestPass = true;
                Assert.IsTrue(TestPass);
            }
        }

        [TestMethod]
        public void EnumeratedVisaTypeUnitTest()
        {
            //Arrange
            int testId;
            string Name = "";
            Boolean TestPass = false;
            //Act
            Name = UnitTestHarnessForCreditCardObjectTypes.Visa.Name;
            testId = UnitTestHarnessForCreditCardObjectTypes.Visa.Id;
            //Assert
            if ((Name == "Visa") && (testId == 2))
            {
                TestPass = true;
                Assert.IsTrue(TestPass);
            }
        }

    }

    public class UnitTestHarnessForCreditCardObjectTypes : Enumeration
    {
        public static UnitTestHarnessForCreditCardObjectTypes Amex = new UnitTestHarnessForCreditCardObjectTypes(1, "Amex");
        public static UnitTestHarnessForCreditCardObjectTypes Visa = new UnitTestHarnessForCreditCardObjectTypes(2, "Visa");

        public UnitTestHarnessForCreditCardObjectTypes(int id, string name)
            : base(id, name)
        {
        }
    }

}
