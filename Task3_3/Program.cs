namespace Task3_3
{
    internal class Program
    {
        //Вводятся четыре числа. Вывести большее из них.
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int max1 = (a > b) ? a : b;

            int max2 = (c > d) ? c : d;

            int max = (max1 > max2) ? max1 : max2;

            Console.WriteLine($"Максимальное число: {max}");

            Console.ReadKey();

        }
    }
}
