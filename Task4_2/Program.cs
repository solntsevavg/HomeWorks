namespace Task4_2
{
    internal class Program
    {
        //Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Введите натуральное число: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);


            double sum = 0;

            for (int i = 1; i <= n; i++)

            {
                sum = sum + 1 / Convert.ToDouble(i);

            }

            Console.WriteLine($"Полученное значение 1+...+1/{n} = {sum} ");
            Console.ReadKey();


        }
    }
}
