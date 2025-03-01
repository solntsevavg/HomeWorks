namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество домов: ");

            int n = Convert.ToInt32(Console.ReadLine());

            if ((n % 100 >= 11 && n % 100 <= 19) || (n % 10 >= 5 && n % 10 <= 9) || (n % 10 == 0))

            {
                Console.WriteLine($"Мы построили {n} домов");
            }
            else
            {
                if (n%10 == 1)
                { Console.WriteLine($"Мы построили {n} дом"); }
                else
                { Console.WriteLine($"Мы построили {n} дома"); }

            }   
            

            Console.ReadKey();
        }
    }
}
