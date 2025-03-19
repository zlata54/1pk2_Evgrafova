namespace Task_11_06
{
    internal class Program
    {
        /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и
         * изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
         * массив вне метода.
         */
        static void Main(string[] args)
        {
            // создаем и заполняем массив случайными целыми числами
            Random rnd = new Random();
            int[] Array = new int[10];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rnd.Next(1, 100);
            }
            //выводим изначальный массив и после изменения
            Console.WriteLine("Изначальный массив:");
            foreach (int number in Array)
            {
                Console.WriteLine(number);
            }

            Array2(Array);

            Console.WriteLine("Массив после изменения его элементов:");
            foreach (int number in Array)
            {
                Console.WriteLine(number);
            }
        }
        /// <summary>
        /// Увеличивает каждый элемент массива на 1.
        /// </summary>
        /// <param name="array">Массив целых чисел, элементы которого будут увеличены.</param>
        static void Array2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
        }
    }
}
