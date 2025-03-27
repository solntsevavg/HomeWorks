namespace Task2_5
{
    internal class Program
    {
        //Вводится длина трубы в метрах. Округлить длину до целых в большую сторону. Например, 

        //17,0  -> 17
        //17,3  -> 18
        //17,7  -> 18
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы: ");

            double a = Convert.ToDouble(Console.ReadLine());
            double l = Math.Ceiling(a);



            Console.WriteLine($"Итог округления в большую сторону: {l}");
            Console.ReadKey();
        }
    }
}
