namespace Task5_4
{
    internal class Program
    {
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

            Console.ReadKey();
        }
    }
}
