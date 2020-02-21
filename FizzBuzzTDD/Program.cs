using System;

namespace FizzBuzzTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 1;
            min = Convert.ToInt32(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintFizzBuzz(min, max);
            Console.WriteLine(result);
           
            Console.ReadKey();
        }
    }
}
