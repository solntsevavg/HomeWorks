namespace Task15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём словарь для хранения контактов(имя -> телефон)
            Dictionary<string, int> shopeStore = new Dictionary<string, int>();
            // Добавление товаров
            shopeStore.Add("A001", 10); //ноутбуки
            shopeStore.Add("B205", 25); //смартфоны
            shopeStore.Add("C307", 15); //наушники

            // Проверка наличие товара с артикулом "B205"
            bool hasArtB205 = shopeStore.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasArtB205}");

            // Изменение количества ноутбуков до 8 (продали 2 шт.)
            shopeStore["A001"] = 8;

            // Получение количества наушников безопасным способом
            if (shopeStore.TryGetValue("C307", out int earStore))
            {
                Console.WriteLine($"Количество наушников: {earStore}");
            }

            // Изменение количества смартфонов на 5
            shopeStore["B205"] = 30;

            // Удаление наушников
            shopeStore.Remove("C307");


            // Перебор всех элементов(foreach +KeyValuePair)
            Console.WriteLine("Текущий инвентарь:");
            foreach (KeyValuePair<string, int> position in shopeStore)
            {
                Console.WriteLine($"Артикул: {position.Key}, Количество: {position.Value}");
            }

            // Проверка наличия товаров
            bool f = true;
            if (shopeStore.Count > 0)
                f = false;

            Console.WriteLine($"Инвентарь пуст? {f}");

            // Очистка словаря(Clear)
            shopeStore.Clear();
            Console.WriteLine($"Количество контактов после очистки: {shopeStore.Count}");
            Console.ReadKey();
        }
    }
}
