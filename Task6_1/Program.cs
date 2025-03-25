namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
            //Найти самое длинное слово в строке.

            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' '); // Разделяем строку на слова

            int max = 0;
            string result = string.Empty;

            foreach (string word in words)  // Обрабатываем каждое слово
            {
                if (word.Length > max)
                 max = word.Length;
                result = word;

            }

            Console.WriteLine($"Самое длинное слово:{result}");

            Console.ReadKey();


        }
    }
}
