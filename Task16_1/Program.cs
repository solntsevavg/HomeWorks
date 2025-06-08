using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Task16_1
{

    class Computer
    {
        public string Code { get; set; }
        public string Mark { get; set; }
        public string Processor { get; set; }
        public double Frequency { get; set; }
        public double Ram { get; set; }
        public double Video { get; set; }

        public double Cost { get; set; }

        public int Count { get; set; }
        public void PrintInfo()
        {

            Console.WriteLine($"Код: {Code}; Марка: \"{Mark}\"; Процессор: \"{Processor}\"; Частота: {Frequency} ГГц; ОЗУ: {Ram} Гб; Видеокарта: {Video} Гб; Стоимость: {Cost} руб.; Количество: {Count} шт.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>()
            {
              new Computer() { Code = "001", Mark = "Acer", Processor = "i5", Frequency = 3.3, Ram = 4, Video = 2, Cost = 47500, Count = 30 },
              new Computer() { Code = "002", Mark = "Lg", Processor = "i7", Frequency = 4, Ram = 8, Video = 4, Cost = 33000, Count = 10 },
              new Computer() { Code = "003", Mark = "MSI", Processor = "i9", Frequency = 5, Ram = 8, Video = 6, Cost = 40000, Count = 5 },
              new Computer() { Code = "004", Mark = "Samsung", Processor = "i9", Frequency = 6, Ram = 10, Video = 6, Cost = 47500, Count = 3 },
              new Computer() { Code = "005", Mark = "Apple", Processor = "Ryzen 7", Frequency = 4.5, Ram = 4, Video = 3, Cost = 25000, Count = 21 },
              new Computer() { Code = "006", Mark = "Iru", Processor = "Ryzen 5", Frequency = 5, Ram = 6, Video = 4, Cost = 25000, Count = 13 },
              new Computer() { Code = "007", Mark = "Noname", Processor = "Ryzen 9", Frequency = 3, Ram = 8, Video = 6, Cost = 41100, Count = 32 },
             };

            //- все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.Write("Введите тип процессора: ");

            string p = Console.ReadLine();

            var processorComps = list
                .Where(comp => comp.Processor == p);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nВсе компьютеры с процессором {p}:");
            Console.ResetColor();

            foreach (var comp in processorComps)
            {
                comp.PrintInfo();
            }

            //- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.Write("\nВведите объем ОЗУ: ");

            double r = Convert.ToDouble(Console.ReadLine());

            var ramComps = list
                .Where(comp => comp.Ram == r);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nВсе компьютеры с объемом ОЗУ {r}:");
            Console.ResetColor();

            foreach (var comp in ramComps)
            {
                comp.PrintInfo();
            }

            //- вывести весь список, отсортированный по увеличению стоимости;

            var sortedByCost = list
                .OrderBy(comp => comp.Cost);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nВсе компьютеры в порядке увеличения стоимости:");
            Console.ResetColor();

            foreach (var comp in sortedByCost)
            {
                comp.PrintInfo();
            }

            // - вывести весь список, сгруппированный по типу процессора;


            var groupProcessor = list
                .GroupBy(comp => comp.Processor);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nВсе компьютеры, отсортированные по типу процессора:");
            Console.ResetColor();

            foreach (var group in groupProcessor)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nПроцессор: {group.Key}");
                Console.ResetColor();

                foreach (var comp in group)
                {
                    comp.PrintInfo();
                }
            }

            //- найти самый дорогой и самый бюджетный компьютер;

            var minCost = list
                .Min(comp => comp.Cost); // будет выводится только цена

            var minComp = list
                .Where(comp => comp.Cost == minCost);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nСамый дешевый компьютер:{minCost} руб.");
            Console.ResetColor();

            foreach (var comp in minComp) //если несколько экзмепляров, то отобразятся все
            {
                comp.PrintInfo();
            }


            //var minCost = list
            //    .OrderBy(comp => comp.Cost).First(); //первый в отсортированном списке по возрастанию


            var maxCost = list
                .Max(comp => comp.Cost); // будет выводится только цена

            var maxComp = list
                .Where(comp => comp.Cost == maxCost);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nСамый дорогой компьютер: {maxCost} руб.");
            Console.ResetColor();

            foreach (var comp in maxComp) //если несколько экзмепляров, то отобразятся все
            {
                comp.PrintInfo();
            }

            //- есть ли хотя бы один компьютер в количестве не менее 30 штук?

            bool hasCount = list
                .Any(comp => comp.Count >= 30);
            Console.WriteLine($"\nЕсть ли хотя бы один компьютер в количестве не менее 30 штук? {(hasCount ? "Да" : "Нет")}");

            if (hasCount)
            {
                var countComp = list
                    .Where(comp => comp.Count >= 30).ToList();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Компьютеры в наличии (>= 30 шт):");
                Console.ResetColor();

                foreach (var comp in countComp)
                {
                    comp.PrintInfo();
                }
            }
            Console.ReadKey();

        }
    }
}
