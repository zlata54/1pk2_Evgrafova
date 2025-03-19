namespace Task_10_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит 
         * на консоль сгенерированный массив размерности n*n.
         */
        static void Main(string[] args)
        {
             //запрашиваем размерность массива, генерируем его и выводим
             Console.WriteLine("Введите размерность массива:");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Сгенерированный массив:");
             ArrayGeneration(n);
        }
            /// <summary>
            /// Генерирует двумерный массив целых чисел размером n x n,
            /// заполняет его случайными числами от 0 до 99 и выводит на консоль.
            /// </summary>
            /// <param name="n">Размерность массива.</param>
            static void ArrayGeneration(int n)
            {
                int[,] Array = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Array[i, j] = rnd.Next(0, 100);
                        Console.Write(Array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }

    }
}


