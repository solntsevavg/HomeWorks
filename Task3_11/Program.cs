namespace Task3_11
{
    internal class Program
    {
        //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров? Дома можно располагать только параллельно сторонам участка.
        //Дома могу стоять «вплотную» друг к другу.
        static void Main(string[] args)
        {
            Console.Write("Введите длину участка: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину участка: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину первого дома: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину первого дома: ");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину второго дома: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину второго дома: ");
            int s = Convert.ToInt32(Console.ReadLine());

            if (((a >= p + r) && (b >= q) && (b >= s)) ||
                ((a >= p + s) && (b >= q) && (b >= r)) ||
                ((a >= q + s) && (b >= p) && (b >= r)) ||
                ((a >= q + r) && (b >= p) && (b >= s)) ||
                ((b >= p + r) && (a >= q) && (a >= s)) ||
                ((b >= p + s) && (a >= q) && (a >= r)) ||
                ((b >= q + s) && (a >= p) && (a >= r)) ||
                ((b >= q + r) && (a >= p) && (a >= s))
               )
                Console.WriteLine($"Можно ли расположить на участке {a}х{b} дома размерами {p}х{q} и {r}х{s}? : Да ");
            else Console.WriteLine($"Можно ли расположить на участке {a}х{b} дома размерами {p}х{q} и {r}х{s}? : Нет ");

            Console.ReadKey();
        }
    }
}
