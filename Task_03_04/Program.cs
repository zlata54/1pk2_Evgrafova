namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
         *пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество 
         *строк введенных пользователем.
         */
        static void Main(string[] args)
        { 
            int LineCount = 0;
            string input;
            while (true)
            { 
                Console.Clear();
                Console.WriteLine("Введите текст или exit для выхода:");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || input=="exit")
                {
                    break;
                }
                LineCount++;
            }
            Console.Clear() ;
            Console.WriteLine($"Количество введённых строк:{LineCount}");
        }
    }
}
