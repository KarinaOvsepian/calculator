namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Простий калькулятор ===");

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = AddNumbers(num1, num2);

            Console.WriteLine($"Результат додавання: {result}");
        }

        
        static double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}