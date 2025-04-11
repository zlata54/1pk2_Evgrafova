namespace Task_20_04
{
    class Program
    {
        /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType
         * • Car
         * • Bike
         * • Bus
         * • Truck
         * • Motorcycle
         * Храните список транспортных средств (можно просто List<VehicleType>). Добавьте метод для 
         * подсчёта транспорта определённого типа (например, сколько грузовиков). Реализуйте поиск по типу
         * и вывод информации.
         */
        static List<VehicleType> vehicles = new List<VehicleType>();

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для учета транспорта");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Добавить транспорт");
                Console.WriteLine("2 - Посчитать транспорт определенного типа");
                Console.WriteLine("3 - Показать весь транспорт");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddVehicle();
                }
                else if (choice == "2")
                {
                    CountVehicles();
                }
                else if (choice == "3")
                {
                    ShowAllVehicles();
                }
                else
                {
                    Console.WriteLine("Произошла ошибка, нужно ввести число от 1 до 3");
                }
            }
        }
        /// <summary>
        /// Запрашивает у пользователя тип транспорта и добавляет его в список.
        /// Проверяет корректность введенных данных.
        /// </summary>
        static void AddVehicle()
        {
            Console.WriteLine("\nВыберите тип транспорта:");
            Console.WriteLine("1 - Легковая машина");
            Console.WriteLine("2 - Велосипед");
            Console.WriteLine("3 - Автобус");
            Console.WriteLine("4 - Грузовик");
            Console.WriteLine("5 - Мотоцикл");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int typeNumber) && typeNumber >= 1 && typeNumber <= 5)
            {
                VehicleType newVehicle = (VehicleType)typeNumber;
                vehicles.Add(newVehicle);
                Console.WriteLine($"Добавлен: {newVehicle}");
            }
            else
            {
                Console.WriteLine("Произошла ошибка, нужно ввести число от 1 до 5");
            }
        }
        /// <summary>
        /// Запрашивает у пользователя тип транспорта и считает, сколько
        /// транспортных средств данного типа было добавлено.
        /// </summary>
        static void CountVehicles()
        {
            Console.WriteLine("\nКакой тип транспорта посчитать?");
            Console.WriteLine("1 - Легковая машина");
            Console.WriteLine("2 - Велосипед");
            Console.WriteLine("3 - Автобус");
            Console.WriteLine("4 - Грузовик");
            Console.WriteLine("5 - Мотоцикл");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int typeNumber) && typeNumber >= 1 && typeNumber <= 5)
            {
                VehicleType typeToCount = (VehicleType)typeNumber;
                int count = 0;

                foreach (VehicleType vehicle in vehicles)
                {
                    if (vehicle == typeToCount)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Всего {typeToCount}: {count} шт.");
            }
            else
            {
                Console.WriteLine("Произошла ошибка, нужно ввести число от 1 до 5");
            }
        }
        /// <summary>
        /// Показывает все транспортные средства, добавленные в список.
        /// Если список пуст, выводит соответствующее сообщение.
        /// </summary>
        static void ShowAllVehicles()
        {
            Console.WriteLine("\nВесь транспорт в списке:");

            if (vehicles.Count == 0)
            {
                Console.WriteLine("В списке нет какого-либо транспорта");
            }
            else
            {
                foreach (VehicleType vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
                Console.WriteLine($"Всего транспорта: {vehicles.Count}");
            }
        }
    }
}
