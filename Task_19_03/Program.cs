namespace Task_19_03
{
    internal class Program
    {
        /* Напишите консольное приложение, в котором осуществляется построчный пользовательский ввод 
         * (ввод каждой строки подтверждается нажатием на enter). количество введенных строк произвольно,
         * ввод завершается при вводе пустой строки. 
         * После окончания ввода произведите объединение всех ранеее введенных строк в одну с 
         * использованием разделителя «-»
         * Например:
         * Введите строку 1: "Hello"
         * Введите строку 2: "world"
         * Введите строку 3: "C#"
         * Результат: "Hello-world-C#"
         */
        static void Main(string[] args)
        {
            string result = string.Empty;
            string input;
            int lineNumber = 1;

            Console.WriteLine("Введите строки (пустая строка для завершения):");

            while (true)
            {
                Console.Write($"Введите строку {lineNumber}: ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                // Если result не пустой, добавляем разделител
                if (!string.IsNullOrEmpty(result))
                {
                    result += "-";
                }

                result += input;
                lineNumber++;
            }

            Console.WriteLine($"\nРезультат: \"{result}\"");
        }
    }
}
