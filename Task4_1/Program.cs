﻿namespace Task4_1
{
    internal class Program
    {
        //Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Введите натуральное число: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);

            int f = 1;

            for (int i = 1; i <= n; i++)

            {
                f = i * f;
            }

            Console.WriteLine($"Полученное значение {n}! = {f} ");
            Console.ReadKey();
        }
    }
}
