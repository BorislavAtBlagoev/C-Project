using System;

namespace _1
{
    public class Program
    {
        public static void Main()
        {
            TRational rational = new TRational(12, 8);

            Console.WriteLine($"{rational.Number}/{rational.Denom} ");

            rational.Reduce();

            if (rational.IsPositive)
            {
                Console.WriteLine($"{rational.Number}/{rational.Denom} ");
            }
            else
            {
                Console.WriteLine($"-{rational.Number}/{rational.Denom} ");
            }
        }
    }
}
