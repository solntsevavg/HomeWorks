using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Task7_3
{
    internal class Program
    {
        //Напишите метод PrintNumbers, который выводит на экран числа из массива.
        //У метода должен быть необязательный параметр reverse, который по умолчанию равен false.
        //Если reverse равен true, числа выводятся в обратном порядке.
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 }; // Массив


            // Вызов метода PrintNumbers - прямой массив
            Console.WriteLine("Прямой массив:");
            PrintNumbers(numbers);

            Console.WriteLine();

            // Вызов метода PrintNumbers - перевернутый массив
            Console.WriteLine("Перевернутый массив:");
            PrintNumbers(numbers, true);

            Console.ReadLine();
        }

        // Метод для вывода элементов массива на экран
        static void PrintNumbers(int[] array, bool reverse = false)
        {
            int n = array.Length;
            if (reverse == false)
            {
                foreach (int element in array) //Вывод в прямом порядке
                    Console.Write($"{element} ");
            }
            else
            {
                for (int i = n-1; i >=0 ; i--) //Вывод в обратном порядке
                {
                    Console.Write($"{array[i]} ");
                }

            }
        }
    }
}
