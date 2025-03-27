namespace Task4_3
{
    internal class Program
    {
        //Вводятся целые числа a>0, b>0. Найти a^b.
        //Не использовать класс Math
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.Write("Введите натуральное число a>0: ");
                a = Convert.ToInt32(Console.ReadLine());

            }
            while (a <= 0);

            int b = 0;
            do
            {
                Console.Write("Введите натуральное число b>0: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b <= 0);

            int c = 1;

            for (int i = 1; i <= b; i++)

            {
                c = c * a;
            }

            double d = Math.Pow(a, b); //Проверка

            Console.WriteLine($"Полученное значение {a}^{b}={c} ");
            Console.WriteLine($"Проверка с помощью Math {a}^{b}={d} ");

            Console.ReadKey();
        }

    }
}
