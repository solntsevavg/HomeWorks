namespace Task2_6
{
    internal class Program
    {
        // Вводится длина трубы в метрах. Округлить длину до 0,5. Например, 
        //17,01 -> 17
        //17,099 -> 17
        //17,1 -> 17
        //17,2 -> 17
        //17,3 -> 17,5
        //17,5 -> 17,5
        //17,51 -> 17,5
        //17,6 -> 17,5
        //17,9 -> 18
        //18 -> 18
        //Примечание.Не использовать условные операторы.
        //Разрешено использовать только математические операции и методы библиотеки Math.


        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Round(a, 2); //труба округл до 2 знаков
            double c = Math.Round(b % 1, 2);
            double o = Math.Round(c / 0.5); // раз 0.5
            double l = b - c + 0.5 * o;


            Console.WriteLine($" Итогое округление длины трубы до 0,5: {l}");
            Console.ReadKey();
        }
    }
}
