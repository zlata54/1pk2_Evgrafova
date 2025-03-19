namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает одномерный массив и число для поиска, верните
         * индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1
         */
        static void Main(string[] args)
        {
            // Запрашиваем размер массива и число для поиска, генерируем и отображаем массив, ищем нужное число
            Console.Write("Введите размер массива: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число для поиска: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = GenerateRandomArray(length);
            DisplayArray(array);
            SearchAndDisplayResult(array, searchNumber);
        }
        /// <summary>
        /// Генерирует массив случайных целых чисел заданного размера.
        /// Случайные числа находятся в диапазоне от 1 до 99.
        /// </summary>
        /// <param name="length">Размер массива.</param>
        /// <returns>Сгенерированный массив целых чисел.</returns>
        static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }
        /// <summary>
        /// Отображает элементы массива на консоли.
        /// Элементы разделяются запятыми.
        /// </summary>
        /// <param name="array">Массив целых чисел для отображения.</param>
        static void DisplayArray(int[] array)
        {
            Console.Write("Сгенерированный массив:" + "\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Ищет указанное число в массиве и отображает результат поиска.
        /// Если число найдено, выводится его индекс, иначе сообщается
        /// о том, что число не найдено.
        /// </summary>
        /// <param name="array">Массив целых чисел, в котором происходит поиск.</param>
        /// <param name="searchNumber">Число, которое нужно найти.</param>
        static void SearchAndDisplayResult(int[] array, int searchNumber)
        {
            int index = SearchInArray(array, searchNumber);
            if (index != -1)
            {
                Console.WriteLine($"Элемент {searchNumber} найден на индексе {index}.");
            }
            else
            {
                Console.WriteLine($"Элемент {searchNumber} не найден в массиве. Индекс = -1.");
            }
        }
        /// <summary>
        /// Ищет элемент в массиве и возвращает его индекс.
        /// Если элемент не найден, возвращает -1.
        /// </summary>
        /// <param name="array">Массив целых чисел, в котором происходит поиск.</param>
        /// <param name="searchNumber">Число для поиска.</param>
        static int SearchInArray(int[] array, int searchNumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

