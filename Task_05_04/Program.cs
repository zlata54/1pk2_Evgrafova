namespace Task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность п*п. Произведите анализ данной матрицы и выясните является
         * ли данная матрица диагональной (все элементы вне главной диагонали равны нулю).Если матрица
         * является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. 
         * Если нет, то вывеси сообщение что матрица не является диагональной
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы:");
            int п=int.Parse(Console.ReadLine());
            int[,] array = new int[п, п];
            Console.WriteLine("Введите элементы массива (каждый элемент с новой строки):");
            for (int i = 0; i < п; i++)
            {
                for (int j = 0; j < п; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool isDiagonal = true;

            for (int i = 0; i < п; i++)
            {
                for (int j = 0; j < п; j++)
                {
                    if (i != j && array[i, j] != 0)
                    {
                        isDiagonal = false;
                    }
                }
            }

            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной");
                for (int i = 0; i < п; i++)
                {
                    for (int j = 0; j < п; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(array[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной");
            }
        }
    }
}
