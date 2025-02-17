namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

             a = a + b;
            b = a - b;
            a = a - b;
            

            Console.WriteLine($"Первое число итог: {a}");
            Console.WriteLine($"Второе число итог: {b}");
            Console.ReadKey();
        }
    }
}
