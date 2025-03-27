namespace Task5_6
{
    internal class Program
    {
        //Сформировать двумерный массив вида

        //1 0 1 0 1
        //0 1 0 1 0
        //1 0 1 0 1
        //0 1 0 1 0
        //1 0 1 0 1
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;

            int[,] t = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = (i + j) % 2 == 0 ? 1 : 0;
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{t[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
