namespace Task17_2
{//Разработать метод для формирования массива и метод для расчета среднего арифметического всех чисел в массиве
    //    (в методах сделать искусственную задержку - имитация длительных вычислений). 
    //    В методе Main выполнить проверку работы методов  с помощью async/await
    internal class Program
    {
        static int[] CreateArrayTask() //Метод для создания массива
        {

            Console.WriteLine("\nГенерация массива...");
            var random = new Random();
            int size = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
            }

            if (array.Length == 0)
                Console.WriteLine("\nМассив не сгенерирован!");
            else
                Console.WriteLine("\nМассив сгенерирован!");

            return array;

        }
        private static int[] _array; //Подсмотрела в deepseek идею, поскольку никак не получалось работать с уже сгенерированным массивом. создавался новый каждый раз.
        static double CalculateMiddleTask() //Метод для вычисления среднего арифметического
        {
            Console.WriteLine("\nВычисление среднего арифметического...");
            try
            {
                int sum = 0;

                foreach (int num in _array)
                {
                    sum += num;
                    Thread.Sleep(300);
                }
                return sum / _array.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                return double.NaN;
            }
        }

        static async Task<int[]> CreateArrayTaskAsync()
        {
            Console.WriteLine("\nCreateArrayTaskAsync запущен");
            _array = await Task.Run(() => CreateArrayTask());
            Console.WriteLine("\nCreateArrayTaskAsync завершен");
            return _array;
        }

        static async Task<double> CalculateMiddleTaskAsync()
        {
            Console.WriteLine("\nCalculateMiddleTaskAsync запущен");
            double result = await Task.Run(() => CalculateMiddleTask());
            Console.WriteLine("\nCalculateMiddleTaskAsync завершен");
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nMain запущен");

            int[] arrayResult = CreateArrayTaskAsync().Result;
            double calcResult = CalculateMiddleTaskAsync().Result;

            Console.WriteLine($"\nСреднее арифметическое: {calcResult}");

            Console.WriteLine("\nMain завершен");
            Console.ReadKey();
        }
    }
}
