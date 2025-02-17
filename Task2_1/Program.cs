namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое значение: ");
            int a = Convert.ToInt32(Console.ReadLine()); //ввод переменных
            Console.Write("Введите второе значение: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье значение: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = b;
            b = a;
            a = c;
            c = d;

            Console.Write($"Результат обмена переменных: {a} {b} {c}");
            Console.ReadKey();
        }


    }
}
