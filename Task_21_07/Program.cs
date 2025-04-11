namespace Task_21_07
{
    internal class Program
    {
        /*Написать метод, который находит первый ключ в словаре, соответствующий заданному значению.
         * Если значения нет, вернуть null.
         */
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>
        {
            { "ваза", 5 },
            { "тарелка", 3 },
            { "кастрюля", 2 },
            { "сковорода", 3 }
        };

            Console.WriteLine("Содержимое словаря:");
            foreach (var pair in myDictionary)
            {
                Console.WriteLine($"Ключ: {pair.Key}, Значение: {pair.Value}");
            }

            Console.WriteLine("\nВведите значение для поиска:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int searchValue))
            {
                string key = FindKeyByValue(myDictionary, searchValue);

                if (key != null)
                {
                    Console.WriteLine($"Первый ключ, соответствующий значению {searchValue}: {key}");
                }
                else
                {
                    Console.WriteLine($"Значение {searchValue} не найдено в словаре.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Неверный ввод.");
            }
        }

        /// <summary>
        /// Находит первый ключ в словаре, соответствующий заданному значению.
        /// </summary>
        /// <param name="dictionary">Словарь, в котором производится поиск.</param>
        /// <param name="value">Значение, для которого необходимо найти соответствующий ключ.</param>
        /// <returns>Первый найденный ключ, соответствующий значению, или null, если значение не найдено.</returns>
        static string FindKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            foreach (var pair in dictionary)
            {
                if (pair.Value == value)
                {
                    return pair.Key;
                }
            }
            return null;
        }
    }
}
