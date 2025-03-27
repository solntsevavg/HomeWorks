namespace Task2_4
{
    internal class Program
    {
        //Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int a = n / 1000;
            int b = (n % 1000)/100; //вторая
            int c = (n % 100)/10;
            int d = n % 10; //четвертая

            n = b + c * 10 + d * 100 + a * 1000;
                                    
            Console.WriteLine($"Заменены вторая и четвертая цифры: {n}");

            Console.ReadKey();
        }
    }
}
