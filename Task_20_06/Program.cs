namespace Task_20_06
{
    internal class Program
    {
        /*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
         * • Red
         * • Yellow
         * • Green
         * Реализуйте автоматическое переключение цветов (каждые 3 секунды). При смене цвета выводите его
         * в консоль (можно с задержкой Thread.Sleep). Добавьте возможность ручного переключения (например,
         * по нажатию клавиши)
         */
        static void Main(string[] args)
        {
            TrafficLightColor currentColor = TrafficLightColor.Red;
            ConsoleKeyInfo keyInfo;

            // Запускаем поток, который будет переключать цвет светофора
            Thread lightChangeThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(3000); // Ожидание 3 секунды
                    currentColor = GetNextColor(currentColor);
                    PrintCurrentColor(currentColor);
                }
            });

            lightChangeThread.IsBackground = true; // Позволяет потоку завершиться при закрытии основной программы
            lightChangeThread.Start();

            Console.WriteLine("Нажмите любую клавишу для переключения цвета вручную.");

            // Обработка ручного переключения цвета
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    currentColor = GetNextColor(currentColor); // Переключаем цвет вручную
                    PrintCurrentColor(currentColor);
                }
            }
        }

        /// <summary>
        /// Выводит текущий цвет светофора на консоль и очищает ее.
        /// </summary>
        /// <param name="color">Цвет светофора, который необходимо отобразить.</param>
        static void PrintCurrentColor(TrafficLightColor color)
        {
            Console.Clear();
            Console.WriteLine($"Цвет светофора: {color}");
        }

        /// <summary>
        /// Устанавливает цвет консоли в зависимости от цвета светофора.
        /// </summary>
        /// <param name="color">Цвет светофора, для которого необходимо установить цвет консоли.</param>
        static void SetConsoleColor(TrafficLightColor color)
        {
            Console.ForegroundColor = color switch
            {
                TrafficLightColor.Red => ConsoleColor.Red,
                TrafficLightColor.Yellow => ConsoleColor.Yellow,
                TrafficLightColor.Green => ConsoleColor.Green,
                _ => ConsoleColor.White
            };
        }

        /// <summary>
        /// Возвращает следующий цвет светофора по кругу.
        /// </summary>
        /// <param name="current">Текущий цвет светофора.</param>
        /// <returns>Следующий цвет светофора.</returns>
        static TrafficLightColor GetNextColor(TrafficLightColor current)
        {
            return current switch
            {
                TrafficLightColor.Red => TrafficLightColor.Yellow,
                TrafficLightColor.Yellow => TrafficLightColor.Green,
                TrafficLightColor.Green => TrafficLightColor.Red,
                _ => TrafficLightColor.Red
            };
        }
    }
}
