using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Shouldly;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzUnitTest
    {
        private FizzBuzzImpl _fb;

        [SetUp]
        protected void SetUp()
        {
            _fb = new FizzBuzzImpl();
        }

        //[Test]
        //public void FizzBuzzWithOne()
        //{
        //    string result = _fb.Compute(1);
        //    result.ShouldBe("1");
        //}

        //[Test]
        //public void FizzBuzzWithThree()
        //{
        //    string result = _fb.Compute(3);
        //    result.ShouldBe("1, 2, Fizz");
        //}

        //[Test]
        //public void FizzBuzzWithFive()
        //{
        //    string result = _fb.Compute(5);
        //    result.ShouldBe("1, 2, Fizz, 4, Buzz");
        //}

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "1, 2, Fizz")]
        [TestCase(5, ExpectedResult = "1, 2, Fizz, 4, Buzz")]
        [TestCase(10, ExpectedResult = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz")]
        [TestCase(15, ExpectedResult = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz")]
        public string CountToNWithFizzBuzz(int n)
        {
            return _fb.Compute(n);
        }
    }
}
