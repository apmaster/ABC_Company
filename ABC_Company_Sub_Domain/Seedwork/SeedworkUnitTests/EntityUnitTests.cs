using System;
using System.Collections.Generic;
using MediatR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seedwork;


namespace SeedworkUnitTests
{
    [TestClass]
    public class EntityUnitTests : Entity,INotification
    {
 
        [TestMethod]
        public void AddDomainEventTestMethod()
        {

            //ARRANGE 
            string Name = "JohnyWhite";
            int PositiveInteger = 47;
            int ZeroInteger = 0;
            int NegativeInteger = -6;
            double PositiveAccuracyNumber = 0.000897532;
            double NegativeAccuracyNumber = -9134.9087;
            object AnyType = "ADB.c" + 789 + "-/" + -89.09 + "~";
      
            //ACT Add Domain Events
            AddDomainEvent(new TestHarness(Name, PositiveInteger, PositiveAccuracyNumber, AnyType));
            AddDomainEvent(new TestHarness(Name, ZeroInteger, PositiveAccuracyNumber, AnyType));
            AddDomainEvent(new TestHarness(Name, NegativeInteger, NegativeAccuracyNumber, AnyType));

            Boolean TestStatusPass = false;
            foreach(TestHarness obj in _domainEvents)
            {
                if(obj.NamingTestCase == Name)
                {
                    TestStatusPass = true;
                }
                else
                {
                     TestStatusPass = false;
                }
                if(obj.NumeracyTestCase == PositiveInteger)
                {
                    TestStatusPass = true;
                }
                else
                {
                    TestStatusPass = false;
                }
                if (obj.NumeracyTestCase == ZeroInteger)
                {
                    TestStatusPass = true;
                }
                else
                {
                    TestStatusPass = false;
                }
                if (obj.NumeracyTestCase == NegativeInteger)
                {
                    TestStatusPass = true;
                }
                else
                {
                    TestStatusPass = false;
                }
                if(obj.AccuracyTestCase == PositiveAccuracyNumber)
                {
                    TestStatusPass = true;
                }
                else
                {
                    TestStatusPass = false;
                }
                if (obj.AccuracyTestCase == NegativeAccuracyNumber)
                {
                    TestStatusPass = true;
                }
                else
                {
                    TestStatusPass = false;
                }
                if (obj.AnyTypeTestCase == AnyType)
                {
                    TestStatusPass = true;
                }
                else
                {
                    TestStatusPass = false;
                }

            }

            //ASSERT 

            Assert.IsTrue(TestStatusPass);
        }

        [TestMethod]
        public void DeleteDomainEventTestMethod()
        {
            //ARRANGE
            string Name = "JohnyWhite";
            int PositiveInteger = 47;
            double PositiveAccuracyNumber = 0.000897532;
            object AnyType = "ADB.c" + 789 + "-/" + -89.09 + "~";
           
            //ACT
            Boolean TestStatusPass = false;
            try
            {
                RemoveDomainEvent(new TestHarness(Name, PositiveInteger, PositiveAccuracyNumber, AnyType));
                TestStatusPass = true;
            }
            catch
            {
                TestStatusPass = false;
            }


            //ASSERT
            Assert.IsTrue(TestStatusPass);
        }

        [TestMethod]
        public void ClearDomainEventTestMethod()
        {
            //ARRANGE
            Boolean TestStatusPass = false;
            //ACT
            try
            {
                ClearDomainEvents();
                TestStatusPass = true;
            }
            catch
            {
                TestStatusPass = false;
            }
            //ASSERT
            Assert.IsTrue(TestStatusPass);
        }

    }

    public class TestHarness:INotification
    {
        public string NamingTestCase
        {
            get; set;
        }
        public int NumeracyTestCase
        {
            get;set;
        }

        public double AccuracyTestCase
        {
            get;set;
        }
        public object AnyTypeTestCase
        {
            get;set;
        }
        public TestHarness (string namingtestcase, int numeracyTestCase,
                            double accuracyTestCase, object anytypeTestCase)
        {
            NamingTestCase = namingtestcase;
            NumeracyTestCase = numeracyTestCase;
            AccuracyTestCase = accuracyTestCase;
            AnyTypeTestCase = anytypeTestCase;
        }
    }
}
