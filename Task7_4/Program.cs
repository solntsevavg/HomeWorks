namespace Task7_4
{
    internal class Program
    {
        // Напишите метод FindMax, который принимает переменное количество чисел
        // и возвращает максимальное значение.Используйте ключевое слово params.

        static void Main()
        {
            // Передача максимального числа

            int maxNumber = FindMax(10, 25, 5, 30, 15);

            Console.WriteLine($"Максимальное число: {maxNumber}");
            Console.ReadKey();
        }

        // Метод для вычисления максимального числа
        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];

            foreach (int number in numbers)

                if (number > max)
                    max = number;

            return max;
        }
    }
}
