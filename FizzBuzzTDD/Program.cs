using System;

namespace FizzBuzzTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            //min = Convert.ToInt32(Console.ReadLine());
            //max = Convert.ToInt32(Console.ReadLine());
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintFizzBuzzLucky(min, max);
            Console.WriteLine(result);
           
            Console.ReadKey();
        }
    }
}
