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

            Console.WriteLine("\nОберіть операцію:");
            Console.WriteLine("1 - Додавання");
            Console.WriteLine("2 - Множення");
            Console.Write("Ваш вибір: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            if (choice == 1)
            {
                result = AddNumbers(num1, num2);
                Console.WriteLine($"\nРезультат додавання: {result}");
            }
            else if (choice == 2)
            {
                result = MultiplyNumbers(num1, num2);
                Console.WriteLine($"\nРезультат множення: {result}");
            }
            else
            {
                Console.WriteLine("\n❌ Невірний вибір операції!");
            }
        }

        // 🔸 Функція додавання
        static double AddNumbers(double a, double b)
        {
            return a + b;
        }

        // 🔸 Функція множення
        static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }
    }
}