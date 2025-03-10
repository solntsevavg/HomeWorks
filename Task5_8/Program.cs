using System.ComponentModel.Design;

namespace Task5_8
{
    internal class Program
    {
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
