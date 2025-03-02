namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.Write("Введите число  [20; 60] : ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a < 20 || a > 60);

            Console.WriteLine("Ввод верный");

            Console.ReadKey();
        }
    }
}
