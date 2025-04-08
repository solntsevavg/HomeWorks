using System;

namespace Task8_1
{
    internal class Program
    {
        //Смоделируйте работу простого калькулятора.
        //Программа должна запрашивать 2 целых числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
        //После этого на консоль выводится ответ. Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).
        static void Main(string[] args)
        {
            int result = 0;
            bool f = true; //для печати результата если нет ошибок
            try
            {
                Console.WriteLine("Введите два целых числа: ");
                int a = Convert.ToInt32(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции (1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное): ");

                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                ValidateCount(c);

                if (c == 1)
                    result = a + b;
                if (c == 2)
                    result = a - b;
                if (c == 3)
                    result = a * b;
                if (c == 4)
                    result = a / b;

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка кода операции: {ex.Message}");
                f = false;
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Введено не число - {ex.Message}");
                f = false;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Деление на 0 - {ex.Message}");
                f = false;
            }

                        if (f) //Выводит результат, если нет ошибок
                Console.WriteLine($"Результат вычислений = {result}");

            Console.ReadKey();
        }

        static void ValidateCount(int c) //Метод для контроля кода операции
        {
            if (c < 1 || c > 4)

                throw new ArgumentException($" {c} выходит за допустимый диапазон [1-4]");
        }
    }
}
