using System.Text.RegularExpressions;

namespace Task6_6a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Регулярное выражение для проверки пароля
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!#;%:?*]).{14,}$";

            // Создание объекта Regex
            Regex regex = new Regex(passwordPattern);

            string password;
            do
            {
                // Запрос пароля у пользователя
                Console.WriteLine("Введите пароль (минимум 14 символов, включая цифру, заглавную и строчную буквы, и специальный символ из набора !#;%:?*):");
                password = Console.ReadLine();

                // Проверка пароля с помощью регулярного выражения
                if (!regex.IsMatch(password))
                {
                    Console.WriteLine("Пароль не соответствует требованиям. Попробуйте снова.");
                }

            } while (!regex.IsMatch(password));

            Console.WriteLine("Пароль принят.");

            Console.ReadKey();
        }
    }
}
