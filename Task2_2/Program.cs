namespace Task2_2
{
    internal class Program
    {
        //Угол а задан в градусах, минутах и секундах. Найти его величину в радианах.
        //Рекомендации по тестированию: проверить работоспособность программы для углов, больших развернутого.
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double u = a / (Math.Abs(a)) * (Math.Abs(a) + b / 60.0 + c / 3600.0); //угол в градусах дробно

            double urad = u * Math.PI / 180; //угол в радианах
            double sinRad = (double)Single.DegreesToRadians((float)u);

            Console.WriteLine($"Итог в градусах: {u}");
            Console.WriteLine($"Итог в радианах: {urad}");
            Console.Write($"Итог в радианах через single: {sinRad}");
            Console.ReadKey();
        }
    }
}