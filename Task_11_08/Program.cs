namespace Task_11_08
{
    internal class Program
    {
        /*Использование params и out: Напишите метод, который принимает переменное количество
         * чисел и возвращает их сумму и максимальное значение через выходные параметры (out).
         */
        static void Main(string[] args)
        {
            // запрашиваем количество чисел, генерируем массив случайных чисел,вычисляем сумму и максимальное значение
            Console.Write("Введите количество чисел: ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = GenerateRandomNumbers(count);

            CalculateSumAndMax(numbers, out int sum, out int max);

            // Вывод результатов
            Console.WriteLine($"Сгенерированные числа: {string.Join(", ", numbers)}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Максимальное значение: {max}");
        }

        /// <summary>
        /// Генерирует массив случайных чисел.
        /// </summary>
        /// <param name="count">Количество случайных чисел, которые нужно сгенерировать.</param>
        /// <returns>Массив случайных целых чисел.</returns>
        static int[] GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            return numbers;
        }

        /// <summary>
        /// Вычисляет сумму и максимальное значение в массиве.
        /// </summary>
        /// <param name="numbers">Массив целых чисел.</param>
        /// <param name="sum">Сумма чисел в массиве.</param>
        /// <param name="max">Максимальное значение в массиве.</param>
        static void CalculateSumAndMax(int[] numbers, out int sum, out int max)
        {
            sum = 0;
            max = int.MinValue;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
        }
    }
}
