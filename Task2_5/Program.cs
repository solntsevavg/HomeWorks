namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы: ");

            double a = Convert.ToDouble( Console.ReadLine());
            double l = Math.Ceiling (a) ;



            Console.WriteLine($"Итог округления в большую сторону: {l}");
            Console.ReadKey();
        }
    }
}
