namespace Task7_5
{
    internal class Program
    {
        //Напишите перегруженные методы Multiply,
        //которые могут умножать два числа(целые или дробные) и возвращать результат.


        static void Main()
        {
            
            int result1 = Multiply(2, 3);
            Console.WriteLine(result1);
            double result2 = Multiply(2.5, 3.5);
            Console.WriteLine(result2);

            Console.ReadKey();
        }

        // Метод для вычисления произведения целых чисел
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // Метод для вычисления произведения дробных чисел
        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
