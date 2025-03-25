namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5; //количество чисел по возрастанию

            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(-50, 51);
                Console.Write($"{t[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (t[i] > t[j])
                    {
                        int a = t[i];
                        t[i] = t[j];
                        t[j] = a;
                    }
                }

            }

            for (int i = m; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (t[i] < t[j])
                    {
                        int a = t[i];
                        t[i] = t[j];
                        t[j] = a;
                    }
                }

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{t[i]} ");
            }

            Console.ReadKey();
        }
    }
}
