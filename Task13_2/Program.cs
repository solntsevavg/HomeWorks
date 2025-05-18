using Microsoft.VisualBasic;

namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int l = abc.Length;

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string result = "";

            int l1 = input.Length;
            input = input.ToUpper();

            foreach (char c in input)
            {
                char k = c;

                if (char.IsLetter(c))
                {
                    for (int i = 0; i < l; i++)
                    {
                        if (c == abc[i])
                        {
                            k = abc[l - i - 1];
                            break;
                        }

                    }
                }
                result = result + k;
            }

            Console.WriteLine($"{input} => {result}");
            Console.ReadKey();
        }
    }
}
