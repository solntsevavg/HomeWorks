namespace Task5_3
{
    internal class Program
    {
        //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
        //Найти и вывести значение максимального, минимального элементов и их индексы
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 51);
                Console.Write($"{t[i]} ");
            }
            Console.WriteLine();

            int max = t[0];
            int maxNumber = 0;
            for (int i = 1; i < n; i++)
                if (t[i] > max)
                {
                    max = t[i];
                    maxNumber = i;
                }

            int min = t[0];
            int minNumber = 0;
            for (int i = 1; i < n; i++)
                if (t[i] < min)
                {
                    min = t[i];
                    minNumber = i;
                }

            Console.WriteLine($"Максимальное число в массиве: {max}");
            Console.WriteLine($"Индекс максимального числа в массиве: {maxNumber}");
            Console.WriteLine($"Минимальное число в массиве: {min}");
            Console.WriteLine($"Индекс минимального числа в массиве: {minNumber}");

            Console.ReadKey();
        }
    }
}
