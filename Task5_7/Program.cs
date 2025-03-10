namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;

            int[,] t = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = rnd.Next(0, 11);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int max = t[i, 0];

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{t[i, j],4} ");

                    if (t[i, j] > max)

                        max = t[i, j];
                }

                Console.Write($" max={max} ");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
