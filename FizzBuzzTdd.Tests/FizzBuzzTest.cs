using FizzBuzzTDD;
using NUnit.Framework;

namespace FizzBuzzTdd.Tests
{
    public class FizzBuzzTest
    {
        int min = int.MinValue;
        int max = int.MaxValue;
        IFizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            min = 1;
            max = 100;
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(-3700000000000000000, 370000)]
        [TestCase(-37000, 3700000000000000000)]
        [TestCase(-37000, -37000)]
        public void Get_Valid_Range_Of_Numbers(long min, long max)
        {
            var valid = fizzBuzz.ValidateMinMax(min, max);
            Assert.IsFalse(valid);
        }

        [Test]
        public void Print_Fizz()
        {
            var result = fizzBuzz.PrintFizz(min, max);
            Assert.IsTrue(result.Contains("Fizz"));
        }

        [Test]
        public void Print_Buzz()
        {
            var result = fizzBuzz.PrintBuzz(min, max);
            Assert.IsTrue(result.Contains("Buzz"));
        }

        [Test]
        public void Print_Fizz_Buzz()
        {
            var result = fizzBuzz.PrintFizzBuzz(min, max);
            Assert.IsTrue(result.Contains("FizzBuzz"));
        }

    }
}