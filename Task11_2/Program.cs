namespace Task11_2
{
    //    Создайте интерфейс IFlyable с:
    //     методом Fly() (без реализации),
    //     свойством MaxAltitude(int, только чтение).

    //Реализуйте интерфейс в классе Bird(птица), добавив:
    //      реализацию Fly() (выводит "Лечу на высоте {MaxAltitude} метров"),
    //      конструктор, принимающий maxAltitude.

    //Реализуйте интерфейс в классе Airplane (самолет), добавив:
    //     свойство CountPassengers - количество пассажиров (int),
    //     реализацию Fly() (выводит "Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров"),
    //     конструктор, принимающий maxAltitude и CountPassengers.

    //В методе Main продемонстрируйте:
    //     создание массива, содержащего объекты обоих типов,
    //     использование полиморфизма (вызовите для каждого элемента в массиве метод Fly()).


    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]  // Массив летающих
            {
                new Bird(25),
                new Airplane(10000, 200)
             };

            foreach (var flyable in flyables)  // Демонстрация полиморфизма
                {
                Console.WriteLine($"{flyable.Name}: {flyable.Fly()}");
                 }

            Console.ReadLine();
        }
    }

    public interface IFlyable // Интерфейс для летающих
    {
        string Name { get; } // Наименование летающего
        string Fly();  //Метод без реализации
        int MaxAltitude { get; } // Свойство только для чтения

    }

    public class Bird : IFlyable // Класс "Птица"
    {

        public string Fly() => $"Лечу на высоте {MaxAltitude} метров."; //Метод для вывода информации

        public int MaxAltitude { get; } //Максимальная высота - свойство

        public string Name => "Птица";

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
    }

    public class Airplane : IFlyable // Класс "Самолет"
    {
        public int CountPassengers { get; }  // Количество пассажиров - свойство
        public string Fly() => $"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров."; //Метод для вывода информации

        public int MaxAltitude { get; } //Максимальная высота - свойство
        
        public string Name => "Самолет";

        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }
    }

}
