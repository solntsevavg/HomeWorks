using System;
using System.Security.Claims;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину отрезка в дюймах: ");

            decimal a = Convert.ToInt32(Console.ReadLine());

            decimal b = a * 254/100;
            decimal m = Math.Floor(b / 100);

            decimal cm = Math.Floor(b % 100);
            decimal mm =(b - m * 100 - cm) * 10;

                        
            Console.WriteLine($"Длина отрезка в метрической системе: {m} м {cm} см {mm} мм"); 
            

            Console.ReadKey();

        }
    }
}
