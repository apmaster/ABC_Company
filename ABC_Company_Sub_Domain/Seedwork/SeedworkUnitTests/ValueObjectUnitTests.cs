using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seedwork;

namespace SeedworkUnitTests
{
    [TestClass]
    public class ValueObjectUnitTests
    {
        /// <summary>
        /// The Aim for the following tests is to
        /// verify the functionality of the 
        /// Value Object in this case treating it
        /// as a dummy customer object. The Dummy
        /// customer object consists of the an Address,
        /// credit Profile, and bank account value object.
        /// </summary>
        [TestMethod]
        public void AddressAggregate()
        {
            //Arrange
            string TestStreet = "123 West Row Blrd.";

            //Act
            var address = new TestHarnessAddressValueObject(TestStreet);

            //Assert
            if(address.Street == TestStreet)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CreditScoreAggregate()
        {
            //Arrange
            int transunionscore = 400;
            int equafaxscore = 500;
            int everydaycredit = 600;
            float overalscore = 0.0f;

            //Act

            var credit = new TestHarnessCreditProfile(transunionscore, equafaxscore, everydaycredit, overalscore);

            //Assert
            if(credit.Overallscore == 500f)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }

    public class TestHarnessAddressValueObject:ValueObject
    {
        public string Street { get; private set; }
        public object City { get; private set; }
        public object State { get; private set; }
        public object Country { get; private set; }
        public object ZipCode { get; private set; }

        public object state { get; private set; }
        public TestHarnessAddressValueObject(string street)
        {
            Street = street;
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return Street;
            yield return City;
            yield return State;
            yield return Country;
            yield return ZipCode;
            yield return state;
        }
    }

    public class TestHarnessCreditProfile : ValueObject
    {
        public int Transunioncreditscore { get; private set; }
        public int Equafax { get; private set; }
        public int Everydaycredit { get; private set; }
        public float Overallscore { get; set; }
        public TestHarnessCreditProfile(int transunioncreditscore, int equafax, int everydaycredit, float overallscore)
        {
            Transunioncreditscore = transunioncreditscore;
            Equafax = equafax;
            Everydaycredit = everydaycredit;

            overallscore = (Transunioncreditscore + Equafax + Everydaycredit) / 3;

            Overallscore = overallscore;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Transunioncreditscore;
            yield return Equafax;
            yield return Everydaycredit;
            yield return Overallscore;
        }
    }
}
