namespace Task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерный массив
        * (состоящийиз символов русского алфавита) и выведите на консоль данный массив с помощью 
        * другого метода (который принимает данный массив в качестве параметра)
        */
        static void Main(string[] args)
        {
            // Запрашиваем количество строк и столбцов у пользователя, генерируем массив и выводим его
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());

            char[,] array = GenerateCharArray(n, m);
            PrintCharArray(array);
        }

        /// <summary>
        /// Генерирует двумерный массив символов, заполненный случайными русскими буквами.
        /// </summary>
        /// <param name="n">Количество строк в массиве.</param>
        /// <param name="m">Количество столбцов в массиве.</param>
        /// <returns>Двумерный массив символов.</returns>
        static char[,] GenerateCharArray(int n, int m)
        {
            char[,] array = new char[n, m];
            //заполняем массив случайными русскими буквами с помощью кодов этих букв
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int randomCode = rnd.Next(1072, 1104);
                    array[i, j] = (char)randomCode;
                }
            }

            return array;
        }

        /// <summary>
        /// Выводит двумерный массив символов в консоль.
        /// </summary>
        /// <param name="array">Двумерный массив символов, который нужно вывести.</param>
        static void PrintCharArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

