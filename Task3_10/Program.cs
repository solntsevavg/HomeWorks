namespace Task3_10
{
    internal class Program
    {
        //Застройщик построил n домов.
        //Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».
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
