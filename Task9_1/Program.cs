using System.Threading.Channels;
using System.Xml.Linq;

namespace Task9_1
{
    //Создайте класс Book, который содержит:
    //Поля:
    //    _title(название книги, private)
    //    _author(автор, private)
    //Автосвойства:
    //    Year(год издания, public геттер, public сеттер)
    //    Pages(количество страниц, public геттер, public сеттер)
    //Конструктор:
    //    Инициализирует все поля и свойства
    //Метод:
    //    GetInfo() – возвращает строку с информацией о книге(например: "Война и мир, Л. Толстой, 1869, 1225 стр.")
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Создаем книгу
               var book1 = new Book("Война и мир", "Л.Толстой", 1869, 1225);
                Console.WriteLine(book1.GetInfo());

                var book2 = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 672);

                Console.WriteLine(book2.GetInfo());
 

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine();

            Book.DisplayTotalBooks();

            Console.ReadKey();
        }
    }

    public class Book
    {

        // Поля
        private string _title; // Название книги 

        private string _author; // Автор

        private int _year; //Год издания

        // Автосвойства
        public int Pages { get; set; } // Количество страниц

        //Свойство с проверкой года
        public int Year
        {
            get => _year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Год не может быть отрицательным!");
                _year = value;
            }
        }


        //Свойство для названия

        public string Title
        {
            get => _title;
            set
            {
                if (value.Length == 0)
                    throw new FormatException($"Пустая строка - название книги!"); 
                _title = value;
            }
        }
        //Свойство для автора

        public string Author
        {
            get => _author;
            set
            {
                if (value.Length == 0)
                    throw new FormatException("Пустая строка - имя автора!");
                _title = value;
            }
        }

        public readonly string BookId; // уникальный ID книги
        public static int TotalBooksCreated = 0; // счетчик созданных позиций книг


        // Конструкторы
        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;

            BookId = Guid.NewGuid().ToString(); // генерируем уникальный ID
            TotalBooksCreated++;

        }

        // Метод возвращает строку с книгой
        public string GetInfo()
        {
            return $"\"{Title}, {Author}, {Year} г., {Pages} стр.,ID: {BookId} \"";
        }

        // Статический метод
        public static void DisplayTotalBooks() //Вывод зависит от количества
        {
            if ((TotalBooksCreated % 100 >= 11 && TotalBooksCreated % 100 <= 19) || (TotalBooksCreated % 10 >= 5 && TotalBooksCreated % 10 <= 9) || (TotalBooksCreated % 10 == 0))

            {
                Console.WriteLine($"Всего создано {TotalBooksCreated} позиций книг.");
            }
            else
            {
                if (TotalBooksCreated % 10 == 1)
                    Console.WriteLine($"Всего создано {TotalBooksCreated} позиция книг.");
                else
                    Console.WriteLine($"Всего создано {TotalBooksCreated} позиции книг.");

            }

        }

    }
}




