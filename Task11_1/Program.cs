namespace Task11_1
{

    //    Создайте абстрактный класс Animal с:
    //        абстрактным свойством Name(string),
    //        абстрактным методом Say(), который выводит звук, который издает животное,
    //        неабстрактным методом ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).

    //Реализуйте два класса-наследника:

    //     Dog(собака), который переопределяет Say() (выводит "Гав!") и задает название животного,
    //     Cat (кошка), который переопределяет Say() (выводит "Мяу!") и задает название животного.

    //В методе Main продемонстрируйте:
    //     создание массива, содержащего объекты обоих типов,
    //     использование полиморфизма (вызовите для каждого элемента в массиве метод ShowInfo()).


    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]  // Массив животных
            {
                new Dog(),
                new Cat()
             };

            foreach (var animal in animals)  // Демонстрация полиморфизма
                animal.ShowInfo();

            Console.ReadLine();
        }
    }

    public abstract class Animal  // Абстрактный класс "Животные"
    {
        public abstract string Name { get; } // Абстрактное свойство для имени животного

        public abstract string Say(); // Абстрактный метод звука животного

        public void ShowInfo()   // Обычный(не абстрактный) метод для вывода
        {
            Console.WriteLine($"Название животного: {Name}");
            Console.WriteLine($"Звук животного: {Say()}");
            Console.WriteLine();
        }
    }

    public class Dog : Animal  // Класс-наследник "Собака"
    {
        public override string Name => "Собака";

        public override string Say()
        {
            return "Гав";
        }
    }
    public class Cat : Animal  // Класс-наследник "Кошка"
    {
        public override string Name => "Кошка";

        public override string Say()
        {
            return "Мяу";
        }
    }
}
