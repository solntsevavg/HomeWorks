using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Runtime.ConstrainedExecution;

namespace Task15_1
{
    internal class Program
    {
        //        Разработайте программу для управления списком игроков команды, используя стандартные методы класса List<T>.
        //Требования:
        //    Создайте список для хранения фамилий игроков(тип string).
        //    Реализуйте следующие операции:
        //        Добавление игроков "Иванов", "Петров", "Сидоров" методом Add.
        //        Вставка игрока "Козлов" на позицию с индексом 1 методом Insert.
        //        Проверка наличия игрока "Петров" в команде методом Contains.
        //        Удаление игрока "Сидоров" методом Remove.
        //        Поиск индекса игрока "Козлов" методом IndexOf.
        //        Сортировка списка по алфавиту методом Sort.
        //        Выведите текущий состав команды в формате:
        //           1. Иванов
        //           2. Козлов
        //           3. Петров
        //        Проверьте, пуст ли список (свойство Count), и очистите его методом Clear.


        static void Main(string[] args)
        {
            // Создаём список для хранения фамилий игроков
            List<string> names = new List<string>();


            // Добавляем задачи(Add)
            names.Add("Иванов");
            names.Add("Петров");
            names.Add("Сидоров");

            // Вставка игрока "Козлов" на позицию с индексом 1
            names.Insert(1, "Козлов");

            //  Проверка наличия игрока "Петров" в команде
            bool hasPetrov = names.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {hasPetrov}");

            // Удаление игрока "Сидоров" 
            names.Remove("Сидоров");


            //  Поиск индекса игрока "Козлов" 
            int kozlovNameIndex = names.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {kozlovNameIndex}");

            //  Сортировка списка по алфавиту
            names.Sort();

            // Выводим текущий состав команды
            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }

            // Проверка наличия игрок в команде
            bool f = true;
            if (names.Count > 0)
                f = false;

            Console.WriteLine($"Команда пуста? {f}");

            // Очищаем список(Clear)
            names.Clear();
            Console.WriteLine($"Количество игроков псоле очистки: {names.Count}");
            Console.ReadKey();
        }
    }
}
