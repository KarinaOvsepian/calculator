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

            Console.Write("Enter operator (+, -, *, /, |): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = Calculate(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }

        static double Calculate(double a, double b, char operation)
        {
            switch (operation)
            {
                case '+': return Add(a, b);
                case '-': return Subtract(a, b);
                case '*': return Multiply(a, b);
                case '/': return Divide(a, b);
                case '^': return Power(a, b);
                default:
                    Console.WriteLine("Unknown operation!");
                    return 0;
            }
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        } static double Power(double a, double b)
        {
            // якщо основа від’ємна і степінь дробовий → помилка
            if (a < 0 && b % 1 != 0)
            {
                Console.WriteLine("Error: Cannot raise a negative number to a fractional power!");
                return double.NaN;
            }

            double result = Math.Pow(a, b);
            Console.WriteLine($"{a} raised to the power of {b} is {result}");
            return result;
        }
        
        static double AbsoluteValue(double a)
        {
            double result = Math.Abs(a);
            Console.WriteLine($"|{a}| = {result}");
            return result;
        }

        public static double Exponentiation()
        { }

        public static double SquareRoot()
        { }
    }
}

