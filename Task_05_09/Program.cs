namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли
         * данная матрица z-матрицей. (это матрица, где все недиагональные элементы меньше нуля)
         *Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной
         *диагонали. Если не выполняется, то вывести сообщение что данная матрица не является z-матрицей
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двумерного массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-10, 10);
                }
            }

            bool isZ = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i, j] >= 0)
                    {
                        isZ = false;
                        break;
                    }
                }
                if (!isZ)
                    break;
            }

            if (isZ)
            {
                Console.WriteLine("Данная матрица является z-матрицей:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(array[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Данная матрица не является z-матрицей");


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }   
    }
} 
