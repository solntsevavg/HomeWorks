namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 1;

            for (int i = 0; Math.Abs (n) > 10; i++)

            {
                n = n / 10;
                s++;
            }

            Console.WriteLine($"Число цифр: {s}");

            Console.ReadKey();
        }
    }
}
