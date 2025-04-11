namespace Task_21_08
{
    internal class Program
    {
        /*напишите метод, который на вход получается массив параметров (строк) и возвращает только
         * уникальные строки
         */
        static void Main(string[] args)
        {
            string[] inputArray = { "Маша", "Карина", "Николай", "Анатолий", "Карина", "Евгения" };

            Console.WriteLine("Начальный массив:");
            foreach (var str in inputArray)
            {
                Console.WriteLine(str);
            }

            // Получаем и выводим уникальные строки
            List<string> uniqueStrings = GetUniqueStrings(inputArray);
            Console.WriteLine("\nУникальные строки:");
            foreach (var str in uniqueStrings)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// Извлекает уникальные строки из заданного массива строк.
        /// </summary>
        /// <param name="input">Массив строк, из которого нужно извлечь уникальные элементы.</param>
        /// <returns>Список уникальных строк.</returns>
        static List<string> GetUniqueStrings(string[] input)
        {
            List<string> uniqueList = new List<string>();

            foreach (var str in input)
            {
                // Проверяем, если строка уже содержится в списке. Если нет, то добавляем ее в список уникальных строк
                if (!uniqueList.Contains(str))
                {
                    uniqueList.Add(str);
                }
            }

            return uniqueList;
        }
    }
}
