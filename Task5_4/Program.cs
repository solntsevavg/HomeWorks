namespace Task5_4
{
    internal class Program
    {
        //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
        //Перевернуть массив, т.е. переставить элементы массива в обратном порядке
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];

            Random rnd = new Random();

            int[] k = new int[n];

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 10);
                Console.Write($"{t[i]} ");
                k[n - 1 - i] = t[i];
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{k[i]} ");

            }
            Console.WriteLine();
            // Второй способ
            Console.WriteLine("Второй способ");

            Console.WriteLine("Прямой массив");
            for (int i = 0; i < n; i++) //Вводится прямой массив
            {
                t[i] = rnd.Next(0, 10);

                Console.Write($"{t[i]} ");

            }
            Console.WriteLine();

            Console.WriteLine("Перевернутый массив");

            for (int i = 0; i < n / 2; i++)
            {
                int p = t[i];
                t[i] = t[n - 1 - i];
                t[n - 1 - i] = p;
            }

            for (int i = 0; i < n ; i++)
            
                Console.Write($"{t[i]} ");
            
            Console.ReadKey();
        }
    }
}
