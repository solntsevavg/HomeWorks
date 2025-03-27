namespace Task3_12
{
    internal class Program
    {
        // Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
        // Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
        static void Main(string[] args)
        {

            Console.Write("Введите число от 100 до 999: ");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 999 || a < 100)
            {

                Console.WriteLine("Ошибка: Введено не трехзначное число");
            }
            else
            {
                int b = a / 100; //Сотни
                int c = (a % 100) / 10; //Десятки
                int d = a % 10; //Единицы
                int e = a % 100; // 11-19


                switch (b)
                {
                    case 1:
                        Console.Write("Результат: сто ");
                        break;
                    case 2:
                        Console.Write("Результат: двести ");
                        break;
                    case 3:
                        Console.Write("Результат: триста ");
                        break;
                    case 4:
                        Console.Write("Результат: четыреста ");
                        break;
                    case 5:
                        Console.Write("Результат: пятьсот ");
                        break;
                    case 6:
                        Console.Write("Результат: шестьсот ");
                        break;
                    case 7:
                        Console.Write("Результат: семьсот ");
                        break;
                    case 8:
                        Console.Write("Результат: восемьсот ");
                        break;
                    case 9:
                        Console.Write("Результат: девятьсот ");
                        break;

                }

                if (c == 1)
                {
                    switch (e)
                    {
                        case 11:
                            Console.Write("одиннадцать");
                            break;
                        case 12:
                            Console.Write("двенадцать");
                            break;
                        case 13:
                            Console.Write("тринадцать");
                            break;
                        case 14:
                            Console.Write("четырнадцать");
                            break;
                        case 15:
                            Console.Write("пятнадцать");
                            break;
                        case 16:
                            Console.Write("шестнадцать");
                            break;
                        case 17:
                            Console.Write("семнадцать");
                            break;
                        case 18:
                            Console.Write("восемнадцать");
                            break;
                        case 19:
                            Console.Write("девятнадцать");
                            break;

                    }
                }
                else
                {
                    switch (c)
                    {
                        case 2:
                            Console.Write("двадцать ");
                            break;
                        case 3:
                            Console.Write("тридцать ");
                            break;
                        case 4:
                            Console.Write("сорок ");
                            break;
                        case 5:
                            Console.Write("пятьдесят ");
                            break;
                        case 6:
                            Console.Write("шестьдесят ");
                            break;
                        case 7:
                            Console.Write("семьдесят ");
                            break;
                        case 8:
                            Console.Write("восемьдесят ");
                            break;
                        case 9:
                            Console.Write("девятносто ");
                            break;

                    }
                    switch (d)
                    {
                        case 1:
                            Console.Write("один");
                            break;
                        case 2:
                            Console.Write("два");
                            break;
                        case 3:
                            Console.Write("три");
                            break;
                        case 4:
                            Console.Write("четаре");
                            break;
                        case 5:
                            Console.Write("пять");
                            break;
                        case 6:
                            Console.Write("шесть");
                            break;
                        case 7:
                            Console.Write("семь");
                            break;
                        case 8:
                            Console.Write("восемь");
                            break;
                        case 9:
                            Console.Write("девять");
                            break;

                    }
                }

                
            }
            Console.ReadKey();
        }
        
        
    }
}
