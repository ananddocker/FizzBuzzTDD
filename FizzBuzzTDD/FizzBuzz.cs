namespace FizzBuzzTDD
{
    public interface IFizzBuzz
    {
        bool ValidateMinMax(long min, long max);
        string PrintFizz(long min, long max);
        string PrintBuzz(long min, long max);
        string PrintFizzBuzz(long min, long max);
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
            for (long i = min; i <= max; i++)
            {
                if (i % 3 == 0)
                {
                    result += "Fizz ";
                }
                else { result += i.ToString() + " "; }
            }
            return result;
        }

        public string PrintBuzz(long min, long max)
        {
            string result = string.Empty;
            for (long i = min; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    result += "Buzz ";
                }
                else { result += i.ToString() + " "; }
            }
            return result;
        }

        //Refactored to Fizz,Buzz & FizzBuzz
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

    }
}
