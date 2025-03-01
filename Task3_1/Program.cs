namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Результат сравнения чисел: >");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("Результат сравнения чисел: <");

                }
                else
                {
                    Console.WriteLine("Результат сравнения чисел: =");
                }
            }
            Console.ReadKey();

        }
    }
}
