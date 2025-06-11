using System;

namespace Task14_1
{
    //    Реализуйте метод Transform, который принимает массив чисел и делегат для преобразования элементов.Метод должен возвращать новый массив с преобразованными значениями.
    //Требования:
    //    Создайте делегат Transformer, принимающий число и возвращающий число.
    //    Реализуйте метод Transform, который:
    //        Принимает массив int[] и делегат Transformer
    //        Возвращает новый массив, где каждый элемент преобразован через делегат
    //    Продемонстрируйте работу:
    //        Удвоение всех чисел
    //        Возведение в квадрат
    //        Замена чисел на их модули

    internal class Program
    {
        // Делегат принимающий число и возвращающий число.
        public delegate int Transformer(int number);

        public static int[] Transform(int[] numbers, Transformer transform)
        {
         
            // Создаем массив нужного размера
            int[] result = new int[numbers.Length];
            int index = 0;

            // Заполняем массив
            foreach (var number in numbers)
            {
                result[index] = transform(numbers[index]);
                index++;
            }
            return result;
        }

        static void Main(string[] args)
        
        {
            // Использование
            var numbers = new int[] { 1, 2, -3, 4, -5 };

            // 1.Удвоение всех чисел через лямбду
            
            var doubleNumbers = Transform(numbers, n=> n*2);
            Console.WriteLine("Удвоение чисел");
            Console.WriteLine(string.Join(", ", doubleNumbers));

            // 2.Возведение в квадрат через лямбду
            var squareNumbers = Transform(numbers, n => n*n);
            Console.WriteLine("Квадрат чисел");
            Console.WriteLine(string.Join(", ", squareNumbers));

            // 3.Модуль чисел через лямбду
            var absNumbers = Transform(numbers, n => Math.Abs(n));
            Console.WriteLine("Модуль чисел");
            Console.WriteLine(string.Join(", ", absNumbers));


            Console.ReadKey();
        }
    }
}
