using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросите у пользователя имя, возраст и город. Сформируйте строку в формате: "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.

            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            int age = 0;
            do
            {
                Console.Write("Введите Ваше возраст: ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            while (age < 1 || age > 130);

            Console.Write("Введите Ваш город: ");
            string city = Console.ReadLine();

            StringBuilder result = new StringBuilder(); //Используем StringBuilder

            result.Append ("Имя: " + char.ToUpper(name[0]) + name.Substring(1) + ", " ) ; //Делаем первую букву заглавной
            result.Append ("Возраст: " + age + ", " ) ;
            result.Append("Город: " + char.ToUpper(city[0]) + city.Substring(1)); //Делаем первую букву заглавной

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
