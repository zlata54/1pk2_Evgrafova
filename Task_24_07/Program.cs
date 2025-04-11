namespace Task_24_07
{
    internal class Program
    {
        /*Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки,
         * содержащие это слово (регистронезависимо).
         */
        static void Main(string[] args)
        {
            // Путь к файлу
            string filePath = @"C:\Temp\ex1.txt";

            CreateAndWriteFile(filePath); // Создаем и заполняем файл данными

            Console.Write("Введите слово для поиска: ");
            string searchWord = Console.ReadLine();

            List<string> linesContainingWord = FindLinesContainingWord(filePath, searchWord);

            Console.WriteLine($"Строки, содержащие слово '{searchWord}':");
            if (linesContainingWord.Count > 0)
            {
                foreach (var line in linesContainingWord)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
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
                writer.WriteLine("Четвёртая строчка.");
                writer.WriteLine("Пятая Строка");
            }
        }

        /// <summary>
        /// Находит строки в файле, которые содержат указанное слово.
        /// </summary>
        /// <param name="filePath">Путь к файлу, в котором нужно выполнить поиск.</param>
        /// <param name="word">Слово, которое необходимо найти в строках файла.</param>
        /// <returns>Список строк, содержащих указанное слово.</returns>
        static List<string> FindLinesContainingWord(string filePath, string word)
        {
            List<string> result = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(line);
                    }
                }
            }

            return result;
        }
    }
}
