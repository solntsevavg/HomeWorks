using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Task15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание HashSet для хранения уникальных email-адресов
            HashSet<string> userEmails = new HashSet<string>();

            // Добавление новых подписчиков
            userEmails.Add("alice@example.com");
            userEmails.Add("bob@example.com");
            userEmails.Add("charlie@example.com");

            // Попытка добавить дубликат(не добавится)
            bool addedDuplicate = userEmails.Add("alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {addedDuplicate}");

            // Проверка наличия подписчиков в системе
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {userEmails.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {userEmails.Contains("dave@example.com")}");


            // Создание второго множества newSubscribers с подписчиками
            HashSet<string> newSubscribers = new HashSet<string> { "bob@example.com", "dave@example.com", "eve@example.com" };

            // Объединение множеств(UnionWith)
            HashSet<string> allEmails = new HashSet<string>(userEmails);
            allEmails.UnionWith(newSubscribers);

            Console.WriteLine("Подписчики после объединения:");
            foreach (string email in allEmails)
            {
                Console.WriteLine($"- {email}");
            }

            // Пересечение множеств(IntersectWith)
            HashSet<string> commonEmails = new HashSet<string>(userEmails);
            commonEmails.IntersectWith(newSubscribers);
            Console.WriteLine("Общие подписчики:");
            foreach (string email in commonEmails)
            {
                Console.WriteLine($"- {email}");
            }

            // Удаление подписчика
            allEmails.Remove("charlie@example.com");

            // Проверка наличия charlie@example.com
            bool hasCharlie = allEmails.Contains("charlie@example.com");
            Console.WriteLine($"Удалили charlie@example.com? {!hasCharlie}");


            // Количество подписчиков
            Console.WriteLine($"Всего подписчиков: {allEmails.Count}");

            // Проверка на подмножество(IsSubsetOf)
            HashSet<string> testGroup = new HashSet<string> { "bob@example.com", "alice@example.com" };
            Console.WriteLine($"testGroup является подмножеством? {testGroup.IsSubsetOf(allEmails)}");
            // 1Очистка коллекции(Clear)
            allEmails.Clear();
            Console.WriteLine($"Подписчиков после очистки: {allEmails.Count}");
            Console.ReadKey();
        }
    }
}
