namespace Task7_1
{
    internal class Program
    {
        // Два треугольника заданы длинами своих сторон. Определите, площадь какого из них больше
        // (создайте метод Square для вычисления площади треугольника по длинам его сторон).
        // Для решения задачи можно использовать формулу Герона.


        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());

            double result1 = Square(a1, b1, c1);
            double result2 = Square(a2, b2, c2);

            Console.WriteLine($"{Math.Round(result1, 3)}  {Math.Round(result2, 3)}"); // для проверки

            if (result1 == result2)
                Console.WriteLine("Треугольники равны по площади");
            else
            {
                if (result1 > result2)
                    Console.WriteLine("Площадь первого треугольника больше");
                else
                    Console.WriteLine("Площадь второго треугольника больше");
            }

            Console.ReadLine();
        }


        // Вычисление площади по формуле Герона
        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
