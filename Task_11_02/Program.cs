namespace Task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
         * меняет их местами. Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            //запрашиваем два целых числа и выводим их до и после вызова метода для обмена значениями по ссылке
            Console.Write("Введите первое целое число: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Перед вызовом метода: x = {x}, y = {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"После вызова метода: x = {x}, y = {y}");
        }

        /// <summary>
        /// Меняет местами значения двух целых чисел, переданных по ссылке.
        /// </summary>
        /// <param name="x">Первое целое число, которое будет заменено.</param>
        /// <param name="y">Второе целое число, которое будет заменено.</param>
        static void Swap(ref int x, ref int y)
        {
            int a = x;
            x = y;       
            y = a;    
            Console.WriteLine($"Внутри метода: x = {x}, y = {y}");
        }
    }
    
}
