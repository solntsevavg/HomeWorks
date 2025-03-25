namespace Task7_2
{
    internal class Program
    {
        // Создайте метод CalcCube для вычисления объема и площади поверхности куба 
        // по длине его ребра.Метод должен иметь 3 параметра -
        // длина ребра,
        // out-параметр для объема и
        // out-параметр для площади поверхности.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());

            // Переменные для хранения результатов
            double volume;
            double surfaceArea;

            // Вызов метода
            CalcCube(a, out volume, out surfaceArea);

            // Вывод результатов
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
            Console.WriteLine($"Объём куба: {volume}");

            Console.ReadLine();
        }
        // Метод для вычисления периметра и площади прямоугольного треугольника
        static void CalcCube(double a, out double volume, out double surfaceArea)
        {
            surfaceArea = 6 * Math.Pow(a, 2);  // Площадь поверхности куба
            volume = Math.Pow(a, 3);  // Объём куба

        }

    }
}
