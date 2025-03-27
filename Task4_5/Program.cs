namespace Task4_5
{
    internal class Program
    {
        //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
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
