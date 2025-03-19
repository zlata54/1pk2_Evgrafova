namespace Task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
         * возвращает их сумму и произведение через выходные параметры (out).
         */
        static void Main(string[] args)
        {
            //запрашиваем два числа
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Вызов метода с использованием ref и out
            int sum;
            int product;
            Calculate(ref a, ref b, out sum, out product);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }
        /// <summary>
        /// Вычисляет сумму и произведение двух чисел.
        /// </summary>
        /// <param name="x">Первое число, передаваемое по ссылке.</param>
        /// <param name="y">Второе число, передаваемое по ссылке.</param>
        /// <param name="sum">Сумма двух чисел.</param>
        /// <param name="product">Произведение двух чисел.</param>
        static void Calculate(ref int x, ref int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;

        }
    }
    
}
