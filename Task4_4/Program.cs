namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = 0;
            do
            {
                Console.Write("Введите число a>0: ");
                a = Convert.ToInt32(Console.ReadLine());

            }
            while (a <= 0);

            int b = 0;
            do
            {
                Console.Write("Введите число b<0: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b >= 0);

            double c = 1;

            for (int i = 1; i <= Math.Abs(b); i++)

            {
                c = c * a;

            }
            double d = 1 / c;
            double x = Math.Pow(a, b);

            Console.WriteLine($"Полученное значение {a}^{b}={d} ");
            Console.WriteLine($"Проверка с помощью Math {a}^{b}={x} ");

            Console.ReadKey();
        }
    }
}
