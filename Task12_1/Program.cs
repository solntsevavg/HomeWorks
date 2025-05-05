namespace Task12_1
{
    //    Создайте обобщенный класс Book<T, U>, который представляет книгу со следующими свойствами:
    //    Code - уникальный код книги (тип T)
    //    Title - название книги (тип string)
    //    PublicationYear - год публикации(тип U)
    //    Author - автор книги(тип string)

    //Реализуйте в классе:
    //    Конструктор, принимающий все параметры
    //    Переопределенный метод ToString(), возвращающий информацию в формате:
    //    Код: {Code} ({ тип T}), Название: { Title}, Автор: { Author}, Год: { PublicationYear} ({ тип U})

    //Создайте обобщенный метод FindBook, который:
    //    Принимает массив книг Book<T, U>[] и код книги code типа T
    //    Возвращает книгу с указанным кодом или null, если книга не найдена

    //В методе Main продемонстрируйте работу:
    //    Создайте два массива книг:
    //        Первый массив: Code - string(шифр книги), PublicationYear - int
    //        Второй массив: Code - int(инвентарный номер), PublicationYear - string(исторические периоды)
    //    Найдите и выведите информацию о книгах:
    //        Книгу с кодом "F-1234" из первого массива
    //        Книгу с кодом 42 из второго массива
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первый массив: Code - string(шифр книги), PublicationYear - int
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                  new Book <string, int>("F-1234", 1856, "Рассказы", "Толстой Л.Н" ),
                  new Book <string, int>("F-5678", 1968, "Истории", "Иванов И.И")
            };

            //Второй массив: Code - int(инвентарный номер), PublicationYear - string(исторические периоды)
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                  new Book <int,string>(42, "1840-1850",  "Собрание сочинений", "Толстой Л.Н"),
                  new Book <int,string>(98, "1946-1948", "Поэмы" , "Иванов И.И.")
            };

            // Поиск книги с кодом "F-1234" из первого массива
            var book1 = FindBook(books1, "F-1234");
            Console.WriteLine(book1?.ToString() ?? "Книга не найдена");

            //Поиск книги с кодом 42 из второго массива
            var book2 = FindBook(books2, 42);
            Console.WriteLine(book2?.ToString() ?? "Книга не найдена");

            Console.ReadKey();

        }

        // Обобщенный метод
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }
    }

    public class Book<T, U>
    {
        public T Code { get; set; } // уникальный код книги
        public U PublicationYear { get; set; } // год публикации
        public string Title { get; set; } // название книги
        public string Author { get; set; } // автор книги

        //Конструктор
        public Book(T code, U publicationYear, string title, string author)
        {
            Code = code;
            PublicationYear = publicationYear;
            Title = title;
            Author = author;
        }
        // Переопределение ToString для удобного вывода
        public override string ToString()
        => $"{Code} ({typeof(T)}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U)})";

    }

}
