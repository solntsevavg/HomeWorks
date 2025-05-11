using System;
using System.Numerics;
using System.Threading;

namespace Task13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.InitializeGame();
            game.EndGame();

            Console.ReadKey();
        }
    }

    public class Character   //БАЗОВЫЙ КЛАСС
    {
        public string Name { get; set; } // имя персонажа - автосвойство
        public int Health { get; set; } // здоровье - автосвойство
        public int Damage { get; set; } // урон за атаку - автосвойство

        public Character(string name, int health, int damage) //Конструктор базового класса
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public virtual void Attack(Character target) // Виртуальный метод Attack(Character target), уменьшающий здоровье цели (target) на значение Damage и выводящий информацию об атаке.
        {
            if (IsAlive && target.IsAlive)
            {
                target.Health -= Damage;
                Console.WriteLine($"{Name} наносит {Damage} урона {target.Name}.");

                if (!target.IsAlive)
                {
                    Console.WriteLine($"{target.Name} повержен!");
                }
            }
            else if (!IsAlive)
            {
                Console.WriteLine($"{Name} не может атаковать, так как мертв!");
            }
        }

        //Свойство
        public bool IsAlive
        {
            get { return Health > 0; }
        }
    }

    public class Player : Character // КЛАСС-НАСЛЕДНИК ИГРОК
    {
        public int Potion { get; private set; } = 3;
        private const int PotionHP = 10;

        public Player(string name) : base(name, 100, 5) //Конструктор
        {
        }

        public void UseHealthPotion() //Метод для использования зелья
        {
            if (Potion > 0)
            {
                Health += PotionHP;
                Potion--;
                Console.WriteLine($"Уровень здоровья: {Health}. Осталось {Potion} зелий!");
            }
            else
                Console.WriteLine($"Зелья закончились!");
        }
    }
    public class Monster : Character // КЛАСС-НАСЛЕДНИК МОНСТР
    {
        private static readonly Random random = new Random();

        public Monster() : base("Злобный Гоблин", 20, 0) //Конструктор
        {
        }

        public override void Attack(Character target) // переопределенный метод с фиксированным уроном

        {
            Damage = random.Next(1, 7);
            base.Attack(target);
        }
    }

    public class Game  //ХОД ИГРЫ
    {
        private Player player;
        private Monster monster;

        public void InitializeGame() // Инизиализация игры
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===");
            Console.WriteLine("Введите имя вашего персонажа: ");

            string playerName = Console.ReadLine();

            player = new Player(playerName);
            monster = new Monster();

            Console.WriteLine($"Битва начинается! {player.Name} против {monster.Name}!");

            PrintStatus();

            while (player.IsAlive && monster.IsAlive)
            {
                PlayerTurn();
                if (!monster.IsAlive) break;

                MonsterTurn();
                if (!player.IsAlive) break;

                PrintStatus();
            }
        }

        private void PlayerTurn() //Ход игрока
        {
            Console.WriteLine($"Ваш ход:");

            int n = 0;

            while (n != 1 && n != 2) // запрос до правильного ввода
            {
                Console.WriteLine("1  Атаковать / 2 - Использовать зелье здоровья");
                n = Convert.ToInt32(Console.ReadLine());
            }
            if (n == 1)
            {
                player.Attack(monster);
            }
            else
            {
                player.UseHealthPotion();
            }
        }

        private void MonsterTurn() //Ход монстра
        {
            Console.WriteLine($"Ход {monster.Name}:");

            monster.Attack(player);
        }

        public void EndGame()
        {
            Console.WriteLine("Игра окончена!");
            if (player.IsAlive)
            {
                Console.WriteLine($"Поздравляем! {player.Name} победил {monster.Name}!");
            }
            else
            {
                Console.WriteLine($"К сожалению, {monster.Name} победил {player.Name}...");
            }
        }

        private void PrintStatus()
        {
            Console.WriteLine($"Текущее состояние:");

            Console.WriteLine($"{player.Name}: {player.Health} HP, зелья: {player.Potion}");

            Console.WriteLine($"{monster.Name}: {monster.Health} HP");
        }
    }
}







