namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            int s1 = 0; //четные
            int s2 = 0; //нечетные
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 101);
                Console.Write($"{t[i]} ");

                if (t[i] % 2 == 0)
                    s1++;
                else s2++;

            }
            Console.WriteLine();
            Console.WriteLine($"Количество четных чисел: {s1}");
            Console.WriteLine($"Количество нечетных чисел: {s2}"); 

            if (s2>s1)

            Console.WriteLine("Нечетных чисел больше"); 
            else
            {
                if (s1 > s2)

                    Console.WriteLine("Четных чисел больше");
                else
                    Console.WriteLine("Четных и нечетных поровну");
            }
           
            Console.ReadKey();

        }
    }
}
