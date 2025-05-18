namespace Task14_2
{
    //    Реализуйте систему управления умным домом на C# с использованием событий.
    //Система должна отслеживать изменения состояния устройств и уведомлять пользователя о важных событиях.
    //1. Класс SmartHomeSystem
    //Должен содержать:
    //    Список подключенных устройств(например, свет, термостат, дверные датчики)
    //    Методы для управления устройствами:
    //        TurnOnLight() / TurnOffLight()
    //        SetTemperature(int newTemp)
    //        LockDoor() / UnlockDoor()
    //    Событие DeviceStateChanged, срабатывающее при изменении состояния любого устройства.
    //2. Событие DeviceStateChanged
    //Должно передавать:
    //    Тип устройства("Light", "Thermostat", "Door")
    //    Новое состояние(например, "On", "Off", "Locked", "Temperature set to 25°C")
    //    Время изменения.
    //    3. Подписка на события в Main
    //Пример лога при работе программы:
    //[14:30:00] Light: Включен
    //[14:31:15] Thermostat: Температура изменена на 23°C
    //[14:35:40] Door: Заблокирована

    // Делегат для события на изменение сосотояни устройства
    public delegate void DeviceStateChanged(string type, string set);

    public class SmartHomeSystem // Класс умного дома
    {
        public event DeviceStateChanged Changed; // Событие, срабатывающее при изменении состояния любого устройства

        private int _temp;

        public void SetTemperature(int newTemp)
        {
            _temp = newTemp;
            Changed?.Invoke("Thermostat", $"Temperature set to {_temp}°C");
        }

        public void TurnOnLight()
        {
            Changed?.Invoke("Light", "On");
        }

        public void TurnOffLight()
        {
            Changed?.Invoke("Light", "Off");
        }

        public void LockDoor()
        {
            Changed?.Invoke("Door", "Locked");
        }

        public void UnlockDoor()

        {
            Changed?.Invoke("Door", "Unlocked");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var device = new SmartHomeSystem(); // Создаем устройчство свет

            // Подписываемся на событие изменения сосотояния
            device.Changed += (type, set) =>
            {

                
                if (set == "On" || set == "Unlocked" && type != "Thermostat")
                    Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.Red;
                if (type == "Thermostat")
                    Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {type}: {set}");
                Console.ResetColor();
            };

            try
            {
                device.TurnOnLight();
                device.SetTemperature(23);
                device.LockDoor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
