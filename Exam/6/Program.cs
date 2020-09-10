using System;

namespace _6
{
    public class Program
    {
        public static void Main()
        {
            string operationSign = "";
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Please, enter operation sign:");
                operationSign = Console.ReadLine();

                if (operationSign == "END")
                {
                    break;
                }

                Console.WriteLine("Please, enter first number:");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please, enter second number:");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(calculator.Operation(firstNumber, secondNumber ,operationSign));

                Console.WriteLine("If you want to exit enter 'END'! ");
            }
        }
    }
}
