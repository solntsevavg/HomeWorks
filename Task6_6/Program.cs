using System.Text.RegularExpressions;

namespace Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить регулярное выражение для проверки корректности пароля.
            // Пароль должен состоять минимум из 14 символов и иметь в составе
            // минимум одну цифру,
            // заглавную букву,
            // строчную букву и
            // специальный символ из набора!#;%:?*
            // Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.


            Console.Write("Введите пароль (минимум 14 символов, содержит: цифру, заглавную букву, строчную букву и специальный символ из набора!#;%:?* : ");
            string pass = Console.ReadLine();

            int n = 0;
            n = pass.Length;

            while (n < 14)
            {
                Console.Write("Введите пароль не менее 14 символов: ");
                pass = Console.ReadLine();
            }

            Regex regex1 = new Regex(@"[0-9]");
            Regex regex2 = new Regex(@"[A-ZА-я]");
            Regex regex3 = new Regex(@"[a-zа-я]");
            Regex regex4 = new Regex(@"[!#;%:?*]");

            foreach (char c in pass)
            {
                if (regex1.IsMatch(pass))
                {
                    if (regex2.IsMatch(pass))
                    {
                        if (regex3.IsMatch(pass))
                        {
                            if (regex4.IsMatch(pass))
                            {
                                Console.WriteLine("Пароль введен верно!");
                                break;
                            }
                            else
                            {
                                Console.Write("Введите корректный пароль (пароль должен содержать хотя бы один символ из набора !#;%:?*.): ");
                                pass = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.Write("Введите корректный пароль (пароль должен содержать хотя бы одну строчную букву): ");
                            pass = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Write("Введите корректный пароль (пароль должен содержать хотя бы одну заглавную букву): ");
                        pass = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Введите корректный пароль (пароль должен содержать хотя бы одну цифру): ");
                    pass = Console.ReadLine();
                }

            }

            Console.ReadKey();

        }
    }
}
