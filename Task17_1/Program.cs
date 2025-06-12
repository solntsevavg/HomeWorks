namespace Task17_1
{
    //Разработать метод для формирования массива и метод для расчета среднего арифметического всех чисел в массиве
    //    (в методах сделать искусственную задержку - имитация длительных вычислений). 
    //    В методе Main выполнить проверку работы методов  используя задачи продолжения
    internal class Program
    {
        static int[] GenerateArrayTask(int size) //Метод для создания массива
        {
            Console.WriteLine("Генерация массива...");
            var random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
                Thread.Sleep(500);
            }
            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }
        static double CalculateMiddleTask(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического...");

            try
            {
                double sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                    Thread.Sleep(300);
                }
                return sum / array.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                return double.NaN;
            }
        }

        static void Main(string[] args)  //проверка, используя задачи продолжения
        {
            Task<int[]> task1 = Task.Run(() => GenerateArrayTask(100));
            Task<double> task2 = task1.ContinueWith(t =>
            {
                int[] array = t.Result;
                return CalculateMiddleTask(array);
            });
            Console.WriteLine(task2.Result);
            Console.ReadKey();
        }
    }
}
