namespace Task8_2
{
    internal class Program
    {
        //Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
        //•    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
        //•    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").

        static void Main(string[] args)
        {
            int age = 0;
            bool f;
            do    //Запрос возраста, пока не будет введенн правильный
            {
                f = true;
                try
                {
                    Console.Write("Введите ваш возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    ValidateAge(age);
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Ошибка максимального возраста - {ex.Message}");
                    f = false;
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка минимального возраста- {ex.Message}");
                    f = false;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine($"Ошибка! Введено не число - {ex.Message}");
                    f = false;
                }

            }
            while (f == false);

            if (f)
                Console.WriteLine($"Возраст введен корректно. Введенный возраст: {age}");

            Console.ReadKey();
        }
        static void ValidateAge(int a) //Метод для контроля кода операции
        {
            int maxage = 150;
            if (a < 0)
                throw new ArgumentException("отрицательный возраст");

            if (a > maxage)

                throw new ArgumentOutOfRangeException($"возраст больше {maxage} лет");
        }
    }
}
