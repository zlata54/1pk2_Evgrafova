namespace Task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через 
         * выходной параметр количество гласных и согласных букв в этой строке
         */
        static void Main(string[] args)
        {
            //запрашиваем ввести строку, вводим переменные для их подсчета и выводим их значение
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            int vowCount, conCount;

            CountLetters(input, out vowCount, out conCount);

            Console.WriteLine($"Количество гласных букв: {vowCount}");
            Console.WriteLine($"Количество согласных букв: {conCount}");
        }

        /// <summary>
        /// Метод подсчитывает количество гласных и согласных букв в строке.
        /// </summary>
        /// <param name="input">Входная строка для анализа.</param>
        /// <param name="vowCount">Количество гласных букв (выходной параметр).</param>
        /// <param name="conCount">Количество согласных букв (выходной параметр).</param>
        static void CountLetters(string input, out int vowCount, out int conCount)
        {
            vowCount = 0;
            conCount = 0; 
            
            foreach (char i in input)
            {
                if (char.IsLetter(i))
                {
                    if ("aAeEiIoOuUyY".Contains(i))
                    {
                        vowCount++;
                    }
                    else 
                    {
                        conCount++;
                    }
                }
            }
        }
    }
}
