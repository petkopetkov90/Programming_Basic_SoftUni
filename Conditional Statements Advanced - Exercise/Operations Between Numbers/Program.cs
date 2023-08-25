using System;

namespace Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            string calculate = Console.ReadLine();
            
            double result = 0;
            string evenOdd = string.Empty;

            if (calculate == "+")
            {
                result = num1 + num2;
            }
            else if (calculate == "-")
            {
                result = num1 - num2;
            }
            else if (calculate == "*")
            {
                result = num1 * num2;
            }
            else if (calculate == "/")
            {
                result = num1 / num2;
            }
            else
            {
                result = num1 % num2;
            }

            if (result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            if ((calculate == "/" || calculate == "%") && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (calculate == "+" || calculate == "-" || calculate == "*")
            {
                    Console.WriteLine($"{num1} {calculate} {num2} = {result} - {evenOdd}");
            }
            else if (calculate == "/")
            {
                Console.WriteLine($"{num1} {calculate} {num2} = {result:f2}");
            }
            else
            {
                Console.WriteLine($"{num1} {calculate} {num2} = {result}");
            }
        }
    }
}