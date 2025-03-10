namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            int s1 = 0; //положительные
            int s2 = 0; //отрицательные
            int s3 = 0; //равные нулю

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(-20, 21);
                Console.Write($"{t[i]} ");

                if (t[i] > 0)
                    s1++;
                else
                {
                    if (t[i] < 0)
                        s2++;
                    else s3++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество положительных чисел: {s1}");
            Console.WriteLine($"Количество отрицательных чисел: {s2}");
            Console.WriteLine($"Количество чисел равных нулю: {s3}");

            Console.ReadKey();
        }
    }
}
