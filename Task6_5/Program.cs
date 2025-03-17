using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить регулярное выражение для проверки корректности номера телефона. Корректный номер имеет формат +7(123)456-78-90.

            string[] test =

             {"+7(123)456-78-90", "7(123)456-78-90", "+7(12)456-78-90", "+7(123)45678-90", "+7(1235)56-78-90"};

            Regex regex = new Regex(@"^\+7\([0-9]{3}\)[0-9]{3}-\d\d-\d{2}$");

            foreach (string str in test)
                if (regex.IsMatch(str))
                    Console.WriteLine("\"{0}\" - ok", str);
                else
                    Console.WriteLine("\"{0}\" - не ok", str);
            Console.ReadKey();
        }
    }
}
