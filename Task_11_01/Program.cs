namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
         * местами. Проверьте, изменились ли значения переменных вне метода 
         */
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя два числа и выводим их 
            Console.Write("Введите первое целое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Порядок чисел до изменения: x = {x}, y = {y}");

            //сохраняем изначальные значения для последующей проверки
            int originalA = x;
            int originalB = y;
            
            Swap(ref x, ref y);
            //Проверяем, изменились ли значения переменных вне метода
            Console.WriteLine($"Порядок чисел после изменения: x = {x}, y = {y}");
            if (originalA != x || originalB != y)
            {
                Console.WriteLine("Значения переменных изменились.");
            }
            else
            {
                Console.WriteLine("Значения переменных остались прежними.");
            }
        }
        

        /// <summary>
        /// Обменивает местами два целых числа.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        static void Swap(ref int x, ref int y)
            {
                int a = x;
                x = y;
                y = a;
            }

        }

    }
    

