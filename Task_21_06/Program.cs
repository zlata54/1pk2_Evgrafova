namespace Task_21_06
{
    internal class Program
    {
        /*Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок
         */
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 5, 94, 2, 3, 1, 492, 5, 5, 6, 1, 8, 94, 3, 23, 65, 5 };

            Console.WriteLine("Исходный список: ");
            PrintList(myList);

            List<int> resultList = RemoveDuplicates(myList);

            Console.WriteLine("Список без дубликатов: ");
            PrintList(resultList);
        }
        /// <summary>
        /// Удаляет дубликаты из заданного списка целых чисел.
        /// </summary>
        /// <param name="list">Список целых чисел, из которого необходимо удалить дубликаты.</param>
        /// <returns>Новый список целых чисел без дубликатов.</returns>
        static List<int> RemoveDuplicates(List<int> list)
        {
            List<int> uniqueList = new List<int>();

            foreach (int item in list)
            {
                // Проверяем, есть ли элемент уже в уникальном списке
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
            }
            return uniqueList;
        }
        /// <summary>
        /// Выводит элементы заданного списка целых чисел в консоль.
        /// </summary>
        /// <param name="list">Список целых чисел для вывода.</param>
        static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
