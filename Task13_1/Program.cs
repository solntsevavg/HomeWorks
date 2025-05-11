namespace Task13_1
{
    internal class Program
    {

        //Игра «Угадай число» (циклы, условия, Random)
        //Напишите консольную игру, где компьютер загадывает число от 1 до 100, а игрок угадывает его.
        //    Программа должна подсказывать «Больше» или «Меньше».
        //    При угадывании вывести количество попыток.
        //    Используйте цикл while и обработку ввода (если пользователь ввёл не число).
        static void Main(string[] args)
        {
            Random random = new Random();
            int m = random.Next(0, 101);
            int i = 1; // счетчик попыток
            bool f = true;

            while (f)
            {
                try
                {
                    Console.Write("Введите число от 1 до 100: ");
                    int n = Convert.ToInt32(Console.ReadLine()); 

                    f = false;
                    while (m - n != 0)
                    {
                        i++;

                        if (n - m > 0)
                        {
                            Console.Write($"Загаданное число  меньше {n}.");
                            Console.Write($"Введите число от 1 до {n}: ");
                        }
                        else
                        {
                            Console.Write($"Загаданное число больше {n}.");
                            Console.Write($"Введите число от {n} до 100: ");
                        }

                        int k = Convert.ToInt32(Console.ReadLine());
                        n = k;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Введено не число - {ex.Message}");
                    f = true;
                    i++;
                }
            }

            Console.Write($"Число {m} угаданно верно!");
            Console.Write($"Количество попыток: {i}.");
            Console.ReadKey();
        }
    }
}
