namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            double n = Convert.ToDouble(Console.ReadLine());
            int s = 1;
            double m = n;
            for (int i = 0; m > 2; i++)

            {
                m = m / 2;
                s++;
            }

            if (m == 2)
            {
                Console.WriteLine($"Число {n} является степенью двойки? Да");
                Console.WriteLine($"Степень двойки равна {s}");
            }
            else 
            {
                Console.WriteLine($"Число {n} является степенью двойки? Нет");
            }
                        
            Console.ReadKey();
        }
    }
}
