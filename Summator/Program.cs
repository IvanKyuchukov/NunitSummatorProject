using System;

namespace Summator
{
   public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new long[] { 1, 2, 3, 4, 5, 6 });
            if (result == 21)
            {
                Console.WriteLine("pass");
            }
            else 
            {
                Console.WriteLine("Fail");
            }

            int average = Summator.Average(new int[] { 1,11,30 });
            if (average == 14)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
