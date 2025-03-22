namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;
            const int m = 5;

            int[,] t = new int[n, m];

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < n - i; i++)
            {

                for (int j = 0 + i; j < m - i; j++) //верхняя строчка - направо
                {
                    t[i, j] = a + 1;
                    a = t[i, j];
                    b = j;
                }
                if (a == n * m)
                    break;
                for (int k = 1 + i; k < n - i; k++) //правая строчка вниз
                {
                    t[k, b] = a + 1;
                    a = t[k, b];
                    c = k;
                }
                if (a == n * m)
                    break;
                for (int r = m - 2 - i; r >= i; r--) //нижняя строчка налево
                {
                    t[c, r] = a + 1;
                    a = t[c, r];
                    d = r;
                }
                if (a == n * m)
                    break;
                for (int z = n - 2 - i; z >= i + 1; z--) //левая строчка вверх
                {
                    t[z, d] = a + 1;
                    a = t[z, d];
                }
                if (a == n * m)
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{t[i, j],4} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
