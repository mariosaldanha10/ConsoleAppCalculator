using System;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MARIO'S CALCULATOR");
            Console.WriteLine("");
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine("THE RESULT IS: " + (num1 + num2));

            }else if(op == "-")
            {
                Console.WriteLine ("THE RESULT IS: " + (num1 - num2 ));

            }else if (op == "/") {

                Console.WriteLine("THE RESULT IS: " + num1 / num2);

            }else if (op == "*") {

                Console.Write("THE RESULT IS: " + num1 * num2);

            }
            else
            {
                Console.WriteLine("INVALID OPERATOR, PLEASE TRY AGAIN.");

            }

            Console.ReadLine();
        }
    }
}
