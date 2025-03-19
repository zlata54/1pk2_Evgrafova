namespace Task_11_07
{
    internal class Program
    {
        /*Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по
         * ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
         * оригинальный массив вне метода.
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            // Заполнение массива случайными числами от 1 до 100
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            //выводим оригинальный и измененный массив
            Console.WriteLine("Исходный массив:");
            PrintArray(numbers); 

            int[] originalArray = (int[])numbers.Clone();
            IncreaseArrayElements(ref numbers);

            Console.WriteLine("После вызова метода:");
            PrintArray(numbers);

            // Проверка, изменился ли массив
            bool hasChanged = HasArrayChanged(originalArray, numbers);
            Console.WriteLine($"Исходный массив изменился: {hasChanged}");
        }

        /// <summary>
        /// Увеличивает каждый элемент массива на 1.
        /// </summary>
        /// <param name="array">Массив целых чисел, элементы которого будут увеличены.</param>
        static void IncreaseArrayElements(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
        }

        /// <summary>
        /// Проверяет, изменился ли массив по сравнению с оригиналом.
        /// </summary>
        /// <param name="original">Оригинальный массив.</param>
        /// <param name="modified">Измененный массив.</param>
        /// <returns>true, если массив изменился, иначе false.</returns>
        static bool HasArrayChanged(int[] original, int[] modified)
        {
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] != modified[i])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Выводит массив целых чисел в консоль.
        /// </summary>
        /// <param name="array">Массив целых чисел, который нужно вывести.</param>
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.WriteLine(number); // Выводим каждый элемент массива
            }
        }
    }
}


