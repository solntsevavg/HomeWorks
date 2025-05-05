namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Создание малоэтажного здания

            Building buildingSmall = new Building("г. Москва, ул. Строителей, дом 25", 423, 1985);
            buildingSmall.DisplayInfo();
            Console.WriteLine();

            // 2.Создание многоэтажного здания

            MultiBuilding buildingBig = new MultiBuilding("г. Москва, ул. Ленина, дом 11б", 625, 2005, 10, true);
            buildingBig.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();

            //3.Upcasting (приведение производного класса к базовому)

            Building buildingUpcast = buildingBig; // Неявное приведение
            Console.WriteLine("\nПосле upcasting:");
            buildingUpcast.DisplayInfo(); // Вызывается переопределенный метод
            Console.WriteLine();

            //4. Downcasting (обратное приведение с проверкой типа)

            if (buildingUpcast is MultiBuilding)
            {
                MultiBuilding buildingDowncast = (MultiBuilding)buildingUpcast;  //Явное при ведение (вызовет исключение, когда оно невозможно)
                Console.WriteLine("\nПосле downcasting:");
                buildingDowncast.DisplayInfo();
                Console.WriteLine();

                // Альтернативный безопасный способ с as

                var buildingAs = buildingUpcast as MultiBuilding;
                if (buildingAs != null)
                {
                    Console.WriteLine("\nПосле downcasting с as:");
                    buildingAs.DisplayInfo();
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }

    public class Building  //Базовый класс
    {
        // Поля

        protected string _address; //Адрес здания
        protected double _area; //Площадь в квадратных метрах
        protected int _yearBuilt; //Год постройки

        //Конструктор базового класса

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }

        //Свойство
        public int BuildingAge => DateTime.Now.Year - _yearBuilt;  // Рассчитывает текущий возраст здания

        //Виртуальные методы

        public virtual decimal CalculateTax() // Рассчитывает налог (базовая формула: площадь × 1000)
        {
            double tax = _area * 1000;
            return (decimal)tax;
        }

        public virtual void DisplayInfo() //Выводит информацию о здании
        {
            Console.WriteLine($"Адрес здания: {_address}");
            Console.WriteLine($"Площадь здания: {_area} кв.м");
            Console.WriteLine($"Год постройки: {_yearBuilt} г.");
            Console.WriteLine($"Возраст здания: {BuildingAge}");
            Console.WriteLine($"Налог: {CalculateTax():F2} р.");
        }
    }

    public class MultiBuilding : Building  //Класс-наследник - многоэтажные здания
    {
        // Поля

        protected bool _hasElevator; //Наличие лифта
        protected int _floors; //Количество этажей

        //Конструктор класса-наследника

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        //Свойство
        public double AreaPerFloor //Средняя площадь на этаж
        {
            get => _area / _floors;
        }

        //Переопределяем метод расчета налога
        public override decimal CalculateTax() // Рассчитывает налог для многоэтажного здания = площадь × 1000х(1 + (_floors - 1) * 0.05) +5000 за наличие лифта
        {
            int el = 0; //Коэффициент на лифт
            if (_hasElevator)
                el = 5000;

            double k = 1 + (_floors - 1) * 0.05; // Коэффициент на многоэтажность

            double tax1 = _area * 1000 * k + el;

            return (decimal)tax1;
        }
        //        Удобно с помощью base вызвать аналогичный метод в родительском классе

        //public override double CalculateTax()
        //        {
        //            double elevatorTax = _haveElevator ? 5000 : 0;
        //            return base.CalculateTax() * (1 + (_floors - 1) * 0.05) + elevatorTax;
        //        }

                public override void DisplayInfo() //Переопределяем вывод информацию о здании
        {
            base.DisplayInfo(); // Вызов базового метода
            Console.WriteLine($"Количество этажей: {_floors} эт.");
            Console.WriteLine($"Средняя площадь этажа: {AreaPerFloor:F2} кв. м");
            Console.WriteLine($"Наличие лифта: {(_hasElevator ? "да" : "нет")}");

        }
    }
}
