namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Нужно создать отчёт, который будет содержать информацию о продажах за определённый период. Отчёт должен быть отформатирован следующим образом:

            // Название отчёта: "Отчёт о продажах за [месяц] [год]".

            // Информация о продажах:

            // Общая сумма продаж.

            //Количество проданных товаров.

            //Средняя стоимость одного товара.

            Console.Write("Введите месяц: ");
            string input1 = Console.ReadLine();
            Console.Write("Введите год: ");
            string input2 = Console.ReadLine();

            Console.Write("Введите общую сумму продаж: ");
            double sum1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество проданных товаров: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum2 = sum1 / n;


            string result1 = String.Format($"{sum1:n2}");
            string result2 = String.Format($"{n:0,0}");
            string result3 = String.Format($"{sum2:n2}");

            Console.WriteLine();
            Console.WriteLine($"Отчёт о продажах за {input1} {input2}");
            Console.WriteLine();
            Console.WriteLine($"Общая сумма продаж: {result1} р.");
            Console.WriteLine($"Количество проданных товаров: {result2} шт.");
            Console.WriteLine($"Средняя стоимость товаров: {result3} р.");

            Console.ReadKey();
        }
    }
}
