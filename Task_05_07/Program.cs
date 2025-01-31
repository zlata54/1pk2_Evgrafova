using System;

namespace Task_05_07
{
    internal class Program
    /*У пользователя в консоли запрашивается число п, генерируется квадратный массив целых числе (n*n). 
     * Заполнение случайными числами в диапазоне от 10 до 99 включительно. Найти и вывести отдельно
     * минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее минимальный
     * элемент, при выходе цветом выделить пять максимальных значений в массиве
     */
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двумерного массива:");
            int n= Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                }
            }
            Console.WriteLine("Изначальный массив:");
            for(int i = 0;i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    Console.Write(array[i, j]+"\t");
                }
               Console.WriteLine();
            }
            Console.WriteLine("Минимальный элемент матрицы:");
            int minValue = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                    }
                }
            }
            Console.WriteLine(minValue);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] *= minValue;
                }
            }

            int[] maxValues = new int[5];
            for (int i = 0; i < 5; i++)
            {
                maxValues[i] = int.MinValue;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int currentValue = array[i, j];
                    for (int t= 0; t < 5; t++)
                    {
                        if (currentValue > maxValues[t])
                        {
                            for (int m = 4; m > t; m--)
                            {
                                maxValues[m] = maxValues[m - 1];
                            }
                            maxValues[t] = currentValue;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Массив после умножения на минимальный элемент:");

            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isMax = false;
                    for (int t = 0; t < 5; t++)
                    {
                        if (array[i, j] == maxValues[t])
                        {
                            isMax = true;
                            break;
                        }
                    }

                    if (isMax)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
    

