namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

public static double Addition(double a, double b)
    {
        return a + b;
    }

    public static double Subtraction(double a, double b)
    {
        return a - b;
    }

    public static double Multiplication(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        // Перевірка на ділення на нуль
        if (b == 0)
        {
            throw new System.DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}
