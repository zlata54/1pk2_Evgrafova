namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5) массива по следующему правилу:
         *1 столбец содержит нули
         *2 столбец содержит числа кратные 2
         *3 столбец содержит числа кратные 3
         *4 столбец содержит числа кратные 4
         *5 столбец содержит числа кратные 5
         */
        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                    {
                        array[i, j] = 0;
                    }
                    else if (j == 1)
                    {
                        array[i, j] = (i + 1) * 2;
                    }
                    else if (j == 2)
                    {
                        array[i, j] = (i + 1) * 3;
                    }
                    else if (j == 3)
                    {
                        array[i, j] = (i + 1) * 4;
                    }
                    else if (j == 4)
                    {
                        array[i, j] = (i + 1) * 5;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
