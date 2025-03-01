using System;

namespace Task3_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max1 = (a > b) ? a : b;

            int max2 = (max1 > c) ? max1 : c; //Максимальное число

            int min1 = (a > b) ? b : a;

            int min2 = (min1 > c) ? c : min1; //Минимальное число

            int median = a + b + c + - max2 - min2;

            Console.WriteLine($"Максимальное число: {max2}");

            Console.WriteLine($"Медиана: {median}");

            Console.ReadKey();

        }
    }
}
