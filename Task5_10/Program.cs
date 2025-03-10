namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int[,] t = new int[n, n];
            Random rnd = new Random();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = rnd.Next(0, 2);
                    Console.Write($"{t[i, j]} ");
                }
                Console.WriteLine();
            }

            bool f1 = true;

            for (int i = 0; i < n; i++) // первая диагональ
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && t[i, j] == 0)
                    {
                        f1 = false;
                        break;
                    }
                }
            }
            if (f1)
                Console.WriteLine("Выиграли крестики? Да");
            else
            {
                bool f2 = true;

                for (int i = 0; i < n; i++) //вторая диагональ
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i + j) == (n - 1) && t[i, j] == 0)
                        {
                            f2 = false;
                            break;
                        }
                    }
                }
                if (f2)
                    Console.WriteLine("Выиграли крестики? Да");
                else
                {
                    bool f3 = true;
                    for (int i = 0; i < n; i++) //строка
                    {
                        f3 = true;
                        for (int j = 0; j < n; j++)
                        {
                            if (t[i, j] == 0)
                            {
                                f3 = false;
                                break;
                            }

                        }
                        if (f3 == true)
                            break;
                    }

                    if (f3)
                        Console.WriteLine("Выиграли крестики? Да");
                    else
                    {
                        bool f4 = true;
                        for (int i = 0; i < n; i++) //столбец
                        {
                            f4 = true;
                            for (int j = 0; j < n; j++)
                            {
                                if (t[j, i] == 0)
                                {
                                    f4 = false;
                                    break;
                                }

                            }
                            if (f4 == true)
                                break;
                        }

                        if (f4)
                            Console.WriteLine("Выиграли крестики? Да");
                        else
                            Console.WriteLine("Выиграли крестики? Нет");

                    }
                }
            }
            Console.ReadKey();
        }
    }
}






