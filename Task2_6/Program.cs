namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Round(a, 2); //труба округл до 2 знаков
            double c = Math.Round(b % 1, 2);  
            double o = Math.Round(c / 0.5 ) ; // раз 0.5
            double l = b - c + 0.5 * o;

            
            Console.WriteLine($" Итогое округление длины трубы до 0,5: {l}");
            Console.ReadKey();
        }
    }
}
