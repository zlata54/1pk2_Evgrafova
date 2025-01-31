namespace Task_05_03
{
    internal class Program
    {
        /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются
         * ли матрицы равными, если да, то вывести сообщение о том, что они равны, если нет, то вывести
         * повторно матрицы с цветовой индикацией только тех элементов, которые равны (матрицы считаются 
         * равными, если их соответствующие элементы равны
         */
        static void Main(string[] args)
        {
            char[,] array1 = new char[3, 3];
            char[,] array2 = new char[3, 3];

            Console.WriteLine("Введите английские буквы первой матрицы (3 строки по 3 столбца букв без пробелов):");
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = input[j];
                }
            }

            Console.WriteLine("Введите английские буквы второй матрицы (3 строки по 3 столбца букв без пробелов):");
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = input[j];
                }
            }

            bool isSame = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array1[i, j] != array2[i, j])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (!isSame) break;
            }

            if (isSame)
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                Console.WriteLine("Матрицы не равны. Cовпадающие буквы:");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (array1[i, j] == array2[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(array1[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write(array1[i, j] + " ");
                        }
                    }
                    Console.Write("   |   ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (array1[i, j] == array2[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(array2[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write(array2[i, j] + " ");
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}

