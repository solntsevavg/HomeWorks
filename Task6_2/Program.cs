using System;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
            //Составить программу, определяющую, является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            input = input.Replace(" ", "");

            input = input.ToLower();

            int n = input.Length; //Длина без пробелов

            bool f = true;

            for (int i = 0; i < n; i++)
            {

                if (input[i] != input[n - 1 - i])
                {
                    f = false;
                    break;
                }
            }

            if (f)

                Console.WriteLine("Предложение является палиндромом");
            else
                Console.WriteLine("Предложение не является палиндромом");

            Console.ReadKey();
        }
    }
}
