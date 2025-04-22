namespace Task9_2
{
    //Создайте класс BankAccount, который моделирует банковский счет:

    //Поля:
    //    _balance(текущий баланс, private)
    //Статическое поле:
    //    TotalAccounts(общее количество созданных счетов)
    //Свойства:
    //    AccountNumber(номер счета, readonly)
    //    Balance(public геттер, private сеттер)
    //Конструктор:
    //    Увеличивает TotalAccounts и генерирует AccountNumber(например, случайный 4-значный номер).
    //Методы:
    //    Deposit(decimal amount) – пополняет баланс.
    //    Withdraw(decimal amount) – снимает деньги(если хватает средств, иначе выбрасывает исключение).
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем счет
                BankAccount ac1 = new BankAccount(2500);

                //Действия с первым счетом
                ac1.Deposit(200);
                ac1.Withdraw(600);

                BankAccount ac2 = new BankAccount(500);

                //Действия со вторым счетом
                ac2.Withdraw(200);
                ac2.Withdraw(600);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine(  );

            Console.WriteLine($"Всего счетов: {BankAccount.TotalAccounts}");

            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        // Поля
        private decimal _balance; // Текущий баланс

        //Статическое поле
        public static int TotalAccounts = 0; //Общее количество созданных счетов

        // Поле только для чтения(устанавливается в конструкторе)
        public readonly int AccountNumber; // Номер счета

        //Автосвойства
        public decimal Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        // Конструкторы
        public BankAccount(decimal _balance)
        {
            Random random = new Random();

            AccountNumber = random.Next(1000, 10000); //присвоение 4х значного номера для счета

            Balance = _balance;

            TotalAccounts++;
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Номер счета: {AccountNumber}, Баланс счета: {Balance} р.");
            Console.WriteLine($"Операция ПОПОЛНЕНИЕ: +{amount} р.");

            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть положительной");

            Balance = Balance + amount;

            Console.WriteLine($"Баланс после пополнения: {Balance} р.");

            Console.WriteLine();
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Номер счета: {AccountNumber}, Баланс счета: {Balance} р.");
            Console.WriteLine($"Операция СПИСАНИЕ: -{amount} р.");

            if (amount <= 0)
                throw new ArgumentException($"Сумма списания должна быть положительной. Номер счета: {AccountNumber}");

            if (amount > Balance)
                throw new ArgumentException($"На счете {AccountNumber} недостаточно средств! Максимально возможная сумма для списания: {Balance} р.");

            Balance = Balance - amount;

            Console.WriteLine($"Баланс после списания: {Balance} р.");
            Console.WriteLine();
        }


    }
}
