using System.ComponentModel.Design;

namespace Task5_8
{
    internal class Program
    {
        //Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10].
        //Найти два наибольших элемента.
        //Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8. Среди чисел {5, 9, 1, 9, 3} два наибольших числа – 9 и 9
        static void Main(string[] args)
        {
            const int n = 5;
            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.Write($"{t[i]} ");
            }
            Console.WriteLine();


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (t[i] >t[j])
                    {
                        int p = t[i];
                        t[i] = t[j];
                        t[j] = p;
                    }
                }
            }
           
            Console.WriteLine($"Два наибольших элемента в массиве: {t[n-1]}, {t[n-2]}");

            Console.ReadKey();

        }
    }
}
