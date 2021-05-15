using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;
        [TestInitialize]
        public void InitializeTest()
        {
            var dic = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
                { 7, "Pop" }
            };
            fizzBuzz = new FizzBuzz(dic);
        }

        [TestMethod()]
        public void GetScoreWithNormalNumberTest()
        {
            var result = fizzBuzz.GetScore(11);
            Assert.AreEqual("11", result);
        }

        [TestMethod]
        public void GetScoreWithNumberMultiplyByThreeTest()
        {
            var result = fizzBuzz.GetScore(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetScoreWithNumberMultiplyByFiveTest()
        {
            var result = fizzBuzz.GetScore(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetScoreWithNumberMultiplyByFiveAndThree()
        {
            var result = fizzBuzz.GetScore(15);
            Assert.AreEqual("Fizz Buzz", result);
        }

        [TestMethod]
        public void GetScoreWithNumberMultiplyBySeven()
        {
            var result = fizzBuzz.GetScore(7);
            Assert.AreEqual("Pop", result);
        }

        [TestMethod]
        public void GetScoreWithNumberMultiplyByThreeAndSeven()
        {
            var result = fizzBuzz.GetScore(21);
            Assert.AreEqual("Fizz Pop", result);
        }

        [TestMethod]
        public void GetScoreWithNumberMultiplyByFiveAndSeven()
        {
            var result = fizzBuzz.GetScore(35);
            Assert.AreEqual("Buzz Pop", result);
        }

        [TestMethod]
        public void GetScoreWithnumberMultiplyByThreeFiveAndSeven()
        {
            var result = fizzBuzz.GetScore(105);
            Assert.AreEqual("Fizz Buzz Pop", result);
        }

        [TestMethod]
        public void GetScoreWithCustomSubstitution()
        {
            fizzBuzz.NumberWordPairs = new Dictionary<int, string> { { 2, "Fuzz" } };
            var result = fizzBuzz.GetScore(2);
            Assert.AreEqual("Fuzz", result);
        }

        [TestMethod]
        public void GetScoreWithMultipleCustomSubstitution()
        {
            fizzBuzz.NumberWordPairs = new Dictionary<int, string>
            {
                { 2, "Fuzz"},
                { 3, "Bizz" }
            };
            var result = fizzBuzz.GetScore(12);
            Assert.AreEqual("Fuzz Bizz", result);
        }
    }
}