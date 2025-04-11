namespace Task_21_10
{
    internal class Program
    {
        /*Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, 
         * суммировать их значения.
         */
        static void Main(string[] args)
        {
            var dictionary1 = new Dictionary<string, int>
            {
             { "молоко", 3 },
             { "хлеб", 5 },
             { "майонез", 2 }
            };

            var dictionary2 = new Dictionary<string, int>
            {
             { "майонез", 4 },
             { "сосиски", 1 },
             { "сыр", 6 }
            };

            Console.WriteLine("Первый словарь:");
            PrintDictionary(dictionary1);

            Console.WriteLine("\nВторой словарь:");
            PrintDictionary(dictionary2);

            var combinedDictionary = CombineDictionaries(dictionary1, dictionary2);

            Console.WriteLine("\nОбъединенный словарь:");
            PrintDictionary(combinedDictionary);
        }

        /// <summary>
        /// Выводит содержимое словаря на консоль.
        /// </summary>
        /// <param name="dictionary">Словарь, который нужно вывести.</param>
        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (var key in dictionary)
            {
                Console.WriteLine($"{key.Key}: {key.Value}");
            }
        }

        /// <summary>
        /// Объединяет два словаря, суммируя значения для общих ключей.
        /// </summary>
        /// <param name="firstDictionary">Первый словарь.</param>
        /// <param name="secondDictionary">Второй словарь.</param>
        /// <returns>Новый словарь, содержащий объединенные ключи и значения.</returns>
        static Dictionary<string, int> CombineDictionaries(Dictionary<string, int> firstDictionary, Dictionary<string, int> secondDictionary)
        {
            var combinedDictionary = new Dictionary<string, int>(firstDictionary);

            foreach (var key in secondDictionary.Keys)
            {
                // Если элемент уже есть в объединенном словаре, суммируем значения, иначе добавляем новый
                if (combinedDictionary.ContainsKey(key))
                {
                    combinedDictionary[key] += secondDictionary[key];
                }
                else
                {
                    combinedDictionary.Add(key, secondDictionary[key]);
                }
            }

            return combinedDictionary;
        }
    }
}
