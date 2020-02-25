using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzzTDD
{
    public interface IFizzBuzz
    {
        bool ValidateMinMax(long min, long max);
        string PrintFizz(long min, long max);
        string PrintBuzz(long min, long max);
        string PrintFizzBuzz(long min, long max);
        string PrintFizzBuzzLucky(int min, int max);
        string PrintFizzBuzzLuckyWithCount(int min, int max);

        int CountFizz(string strResult);
        int CountBuzz(string strResult);
        int CountFizzBuzz(string strResult);
        int CountLucky(string strResult);
        int CountIntegers(string strResult);
    }


    public class FizzBuzz : IFizzBuzz
    {

        public bool ValidateMinMax(long min, long max)
        {
            bool valid = false;
            if (min >= int.MinValue && min <= int.MaxValue && max >= int.MinValue && max <= int.MaxValue && min < max)
            {
                valid = true;
            }
            return valid;
        }

        public string PrintFizz(long min, long max)
        {
            string result = string.Empty;
            if (ValidateMinMax(min, max))
            {
                for (long i = min; i <= max; i++)
                {
                    if (i % 3 == 0)
                    {
                        result += "Fizz ";
                    }
                    else { result += i.ToString() + " "; }
                }
            }
            return result;
        }

        public string PrintBuzz(long min, long max)
        {
            string result = string.Empty;
            if (ValidateMinMax(min, max))
            {
                for (long i = min; i <= max; i++)
                {
                    if (i % 5 == 0)
                    {
                        result += "Buzz ";
                    }
                    else { result += i.ToString() + " "; }
                }
            }
            return result;
        }
        /// <summary>
        /// Refactored to Fizz,Buzz & FizzBuzz, have kept the old functions for demonstration else can be removed
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public string PrintFizzBuzz(long min, long max)
        {
            string result = string.Empty;
            if (ValidateMinMax(min, max))
            {

                for (long i = min; i <= max; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        result += "FizzBuzz ";
                    }
                    else if (i % 3 == 0)
                    {
                        result += "Fizz "; 
                    }
                    else if (i % 5 == 0)
                    {
                        result += "Buzz "; 
                    }
                    else
                    {
                        result += i.ToString() + " ";
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Refactored to Fizz,Buzz, FizzBuzz, FizzBuzzLucky, have kept the old functions for demonstration else can be removed
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public string PrintFizzBuzzLucky(int min, int max)
        {
            string result = string.Empty;
           
            if (ValidateMinMax(min, max))
            {

                for (long i = min; i <= max; i++)
                {
                    if(i.ToString().Contains('3'))
                    {
                        result += "Lucky ";
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        result += "FizzBuzz ";
                    }
                    else if (i % 3 == 0)
                    {
                        result += "Fizz ";
                    }
                    else if (i % 5 == 0)
                    {
                        result += "Buzz ";
                    }
                    else
                    {
                        result += i.ToString() + " ";
                    }
                }
            }
            return result;
        }

        public string PrintFizzBuzzLuckyWithCount(int min, int max)
        {
            var result = PrintFizzBuzzLucky(min, max);
            return result + " Fizz:" + CountFizz(result) + " Buzz:" + CountBuzz(result) + " FizzBuzz:" + CountFizzBuzz(result) + " Lucky:" + CountLucky(result) + " Integer:" + CountIntegers(result);
        }


        public int CountFizz(string strResult)
        {
            var fizzCount = CountStringOccurrences(strResult, "Fizz ");
            return fizzCount;            
        }

        public int CountBuzz(string strResult)
        {
            var fizzCount = CountStringOccurrences(strResult, " Buzz");
            return fizzCount;
        }

        public int CountFizzBuzz(string strResult)
        {
            var fizzCount = CountStringOccurrences(strResult, "FizzBuzz ");
            return fizzCount;
        }

        public int CountLucky(string strResult)
        {
            var fizzCount = CountStringOccurrences(strResult, "Lucky ");
            return fizzCount;
        }

        public int CountIntegers(string strResult)
        {
            return CountIntegersInString(strResult);           
        }

        public static int CountStringOccurrences(string text, string pattern)
        {
           
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        public static int CountIntegersInString(string text)
        {
            var strSplit = text.Split(' ');
            int count = 0;
            foreach (var str in strSplit)
            {
                if(int.TryParse(str, out _))
                {
                    count++;
                }
            }
            
            return count;
        }
    }

}
