using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator ===");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = Calculate(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }

        // 🔹 Ось нова функція — основна логіка калькулятора
        static double Calculate(double a, double b, char operation)
        {
            switch (operation)
            {
                case '+': return Add(a, b);
                case '-': return Subtract(a, b);
                case '*': return Multiply(a, b);
                case '/': return Divide(a, b);
                default:
                    Console.WriteLine("Unknown operation!");
                    return 0;
            }
        }

        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            return a / b;
        }
    }
}