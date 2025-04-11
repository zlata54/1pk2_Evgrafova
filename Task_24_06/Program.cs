namespace Task_24_06
{
    internal class Program
    {
        /*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. Используйте
         * StreamReader.
         */
        static void Main(string[] args)
        {
            string filePath = @"C:\Temp\example.txt";

            CreateAndWriteFile(filePath);

            int lineCount = CountLinesInFile(filePath);
            Console.WriteLine($"Количество строк в файле '{filePath}': {lineCount}");
        }

        /// <summary>
        /// Создает файл и записывает в него несколько строк.
        /// Если директория не существует, она будет создана.
        /// </summary>
        /// <param name="filePath">Путь к файлу, который будет создан или перезаписан.</param>
        static void CreateAndWriteFile(string filePath)
        {
            // Создание директории, если она не существует
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Запись строк в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Первая строка.");
                writer.WriteLine("Вторая строка.");
                writer.WriteLine("Третья строка.");
                writer.WriteLine("Четвёртая строка.");
                writer.WriteLine("Пятая строка.");
            }
        }

        /// <summary>
        /// Считает количество строк в указанном файле.
        /// </summary>
        /// <param name="filePath">Путь к файлу, в котором нужно подсчитать строки.</param>
        /// <returns>Количество строк в файле.</returns>
        static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            // Использование StreamReader для подсчёта строк
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }
    }
}
