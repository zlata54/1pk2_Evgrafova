namespace Task_14_03
{
    internal class Program
    {
        /*Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал.
         * Сделайте так, чтобы метод работал только для неотрицательных чисел.
         */
        static void Main(string[] args)
        {
            //Звпрашиваем число у пользователя
            Console.Write("Введите неотрицательное целое число: ");
            int number = int.Parse(Console.ReadLine());
            //проверяем не является ли число отрицательным, в случае этого выдаем ошибку или выводим факториал,
            //если число не меньше нуля
            if (number < 0)
            {
                Console.WriteLine("Ошибка. Введите неотрицательное число");
            }
            else
            {
                long result = Factorial(number);
                Console.WriteLine($"Факториал числа {number} равен {result}.");
            }
        }
        /// <summary>
        /// Вычисляет факториал неотрицательного числа.
        /// </summary>
        /// <param name="n">Неотрицательное целое число.</param>
        /// <returns>Факториал числа n.</returns>
        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1; 
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
    
}
