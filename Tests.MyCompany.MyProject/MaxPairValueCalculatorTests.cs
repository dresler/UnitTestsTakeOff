using System;
using NUnit.Framework;

namespace Tests.MyCompany.MyProject
{
    [TestFixture]
    public class MaxPairValueCalculatorTests
    {
        [Test]
        public void Calculate_ForEmptyDice_ShouldReturnZero()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Calculate_ForDiceWithoutAnyPair_ShouldReturnZero()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Calculate_ForDiceWithJustOnePair_ShouldReturnSumOfThePair()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Calculate_ForDiceWithTwoPairs_ShouldReturnSumOfTheHigherPair()
        {
            throw new NotImplementedException();
        }

        // Wrong names

        // Cryptic non-explanatory name
        [Test]
        public void TestA()
        {
        }

        // Just a piece of information (UnitOfWork), StateUnderTest and ExpectedBehavior missing
        [Test]
        public void TestCalculate1()
        {
        }

        // Just StateUnderTest
        [Test]
        public void TestNoPair()
        {
        }

        // Missing UnitOfWork
        [Test]
        public void ItShouldReturnZeroForEmptyDices()
        {
        }

        // Confusing order of ExpectedBehavior, UnitOfWork, StateUnderTest
        [Test]
        public void ReturnZeroWhenCalculatesDiceWithoutPair()
        {
        }

        // It describes a particular test case instead of the equivalence partition
        [Test]
        public void Calculate_For123345_ShouldReturn6()
        {
        }
    }
}