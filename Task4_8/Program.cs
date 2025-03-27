namespace Task4_8
{
    internal class Program
    {
        //Вводится число. Вывести его в зеркальном виде.
        //Количество цифр в числе заранее неизвестно. Не использовать строки
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            int m = n;
            for (int i = 0; Math.Abs(m) > 10; i++) // Число цифр

            {
                m = m / 10;
                s++;
            }

            int k = 1;

            for (int i = 1; i < s; i++) // Порядок

            {
                k = k * 10;
            }

            int number = 0;
            int p = n;
            for (int i = 1; i <= s; i++)

            {
                p = n % 10;  //Правая цифра
                n = n / 10;
                number = number + p * k;
                k = k / 10;
            }
            Console.WriteLine($"Зеркальное число: {number}");
            Console.ReadKey();
        }
    }
}
