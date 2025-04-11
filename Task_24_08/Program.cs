namespace Task_24_08
{
    internal class Program
    {
        /*реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, 
         * введенные пользователем
         */
        static void Main(string[] args)
        {
            // Путь к файлу
            string filePath = @"C:\Temp\ex2.txt";

            // Создание файла и запись в него строк
            CreateAndWriteFile(filePath);

            Console.Write("Введите слово для поиска: ");
            string searchWord = Console.ReadLine();

            // Получение строк, содержащих данное слово
            List<string> linesContainingWord = FindLinesContainingWord(filePath, searchWord);

            // Вывод найденных строк
            Console.WriteLine($"Строки, содержащие слово(а) '{searchWord}':");
            if (linesContainingWord.Count > 0)
            {
                foreach (var line in linesContainingWord)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено.");
            }
        }

        /// <summary>
        /// Создает файл и записывает в него несколько строк с примерными данными.
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

            // Создание файла и запись примерных строк
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Первая строка, собака.");
                writer.WriteLine("Вторая строка, кот.");
                writer.WriteLine("Третья строка, хомяк.");
                writer.WriteLine("Четвёртая строка, лебедь.");
                writer.WriteLine("Пятая строка, журавль.");
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

            // Использование StreamReader для чтения строк из файла
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Проверка, содержит ли строка искомое слово (без учета регистра)
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
