using System;

namespace lab1_T4
{
    delegate double Operation(double x);
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послідовно один за одним. Поки вони матимуть вигляд 0 x чи 1 x чи 2 x (тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа), програма обчислюватиме одну з трьох функцій");
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 -- x^3 (інакше кажучи, x*x*x)");
            Console.WriteLine("2 -- x + 3.5");
            Console.WriteLine("Щоб завершити введення, введіть рядок, що не відповідає формату.");

            Operation[] operations = {
                x => Math.Sqrt(Math.Abs(x)),
                x => Math.Pow(x, 3),
                x => x + 3.5
            };
            while (true)
            {
                try
                {
                    Console.Write("Введіть рядок: ");
                    string input = Console.ReadLine();
                    string[] parts = input.Split(' ');

                    int operationIndex = int.Parse(parts[0]);
                    double operand = double.Parse(parts[1]);

                    double result = operations[operationIndex](operand);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Прощальне повідомлення: {ex.Message}");
                    break;
                }
                catch (IndexOutOfRangeException ex) { Console.WriteLine($"Прощальне повідомлення: {ex.Message}");break; }
            }

            Console.WriteLine("Дякуємо за використання програми. Удачі!");
        }

    }
}
