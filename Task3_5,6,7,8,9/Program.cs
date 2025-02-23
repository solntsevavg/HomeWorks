using System.ComponentModel.Design;

namespace Task3_5_6_7_8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 10 == 0) //Условие окончание на 0
            {
                Console.WriteLine("Число заканчивается на 0: Да ");
            }

            else
            {
                Console.WriteLine("Число заканчивается на 0: Нет ");
            }

            if (Convert.ToDouble(a % 2) == 0) //Условие четного числа
            {
                Console.WriteLine("Число четное: Да ");
            }

            else
            {
                Console.WriteLine("Число четное: Нет ");
            }

            if (Math.Abs(a) >= 10 && Math.Abs(a) < 100) //Условие двухзначности
            {
                Console.WriteLine("Число двухзначное: Да ");
            }

            else
            {
                Console.WriteLine("Число двухзначное: Нет ");
            }

            if (Math.Abs(a) >= -10 && Math.Abs(a) <= 10) //Условие число в диапазоне [-10,10]
            {
                Console.WriteLine("Число в диапазоне [-10,10]: Да ");
            }

            else
            {
                Console.WriteLine("Число в диапазоне [-10,10]: Нет ");
            }

            if (Math.Abs(a) <= -10 || Math.Abs(a) >= 10) //Условие число в диапазоне (-∞; -10] Ս [10; +∞)
            {
                Console.WriteLine("Число в диапазоне (-∞; -10] Ս [10; +∞): Да ");
            }

            else
            {
                Console.WriteLine("Число в диапазоне (-∞; -10] Ս [10; +∞): Нет ");
            }


            Console.ReadKey();
        }
    }
}
