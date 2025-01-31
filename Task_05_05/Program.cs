namespace Task_05_05
{
    internal class Program
    /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числел
     * (n*m). Заполнение случайными числами в диапазоне от -99 до 99 включительно. Осуществите без 
     * создания нового массива преобразование текущего по следующему правилу:
     *• Если элемент меньше нуля, то отбрасываем знак и выделяем при выходе зеленым цветом
     *• Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом
     */
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m, n];
            Random rnd = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-99, 100);
                }
            }
            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(array[i, j]) + "\t");
                    }
                    else if (array[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("1\t");
                    }
                    else
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

    }
}
    

