namespace Task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
         * их среднее значение. Используйте ключевое слово params
         */
        static void Main(string[] args)
        {
            // Генерация случайного массива чисел
            Random random = new Random();
            int numberOfElements = 10;
            double[] Array = new double[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Array[i] = random.Next(1, 100);
            }

            Console.WriteLine("Сгенерированные случайные числа:");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine(Array[i]);
            }

            // Вызываем метод для расчета среднего значения
            double average = CalculateAverage(Array);
            Console.WriteLine($"Среднее значение: {average}");
        
        }

        /// <summary>
        /// Метод для вычисления среднего значения чисел.
        /// </summary>
        /// <param name="numbers">Массив чисел.</param>
        /// <returns>Среднее значение.</returns>
        static double CalculateAverage(params double[] numbers)
        {
            if (numbers.Length == 0) return 0;

            double sum = 0;

            foreach (double num in numbers) 
            {
                sum += num;
            }

            return sum / numbers.Length; 
        }
    }
    
}
