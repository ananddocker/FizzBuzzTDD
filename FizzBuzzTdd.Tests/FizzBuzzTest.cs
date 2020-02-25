using FizzBuzzTDD;
using NUnit.Framework;

namespace FizzBuzzTdd.Tests
{
    public class FizzBuzzTest
    {
        int min = int.MinValue;
        int max = int.MaxValue;
        IFizzBuzz fizzBuzz;
        string  strResult =string.Empty;
        [SetUp]
        public void Setup()
        {
            min = 1;
            max = 20;
            fizzBuzz = new FizzBuzz();
            strResult = "1 2 Lucky 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz Lucky 14 FizzBuzz 16 17 Fizz 19 Buzz";
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

        [Test]
        public void Print_Fizz_Buzz_Lucky()
        {
            var result = fizzBuzz.PrintFizzBuzzLucky(min, max);
            Assert.IsTrue(result.Contains("Lucky"));
        }

        [Test]
        public void Count_Fizz()
        {          

            var result = fizzBuzz.CountFizz(strResult);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Count_Buzz()
        {
            var result = fizzBuzz.CountBuzz(strResult);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Count_FizzBuzz()
        {
            var result = fizzBuzz.CountFizzBuzz(strResult);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Count_Lucky()
        {
            var result = fizzBuzz.CountLucky(strResult);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Count_Integers()
        {
            var result = fizzBuzz.CountIntegers(strResult);

            Assert.AreEqual(10, result);
        }


        [Test]
        public void Print_FizzBuzzLucky_With_Count()
        {
            var result = fizzBuzz.PrintFizzBuzzLuckyWithCount(min,max);

            Assert.IsTrue(result.Contains("Fizz:4"));
            Assert.IsTrue(result.Contains("Buzz:3"));
            Assert.IsTrue(result.Contains("FizzBuzz:1"));
            Assert.IsTrue(result.Contains("Lucky:2"));
            Assert.IsTrue(result.Contains("Integer:10"));
        }



    }
}