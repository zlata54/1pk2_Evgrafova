namespace Task_19_02
{
    internal class Program
    {
        /* Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий
         * предложения (есть знаки препинания). программу после анализа выводит текст, разделенный на
         * части:
         * a)	По пробелам (отдельные слова построчно)
         * b)	По предложениям (отдельные предложения построчно)
         * (используйте метод Split())
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для анализа:");
            string inputText = Console.ReadLine();

            string[] words = inputText.Split(new[] { ' ', '!', '?', ',', '.', ';', ':', '—', '(', ')', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nСлова в тексте (по пробелам):");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string[] sentences = inputText.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nПредложения в тексте (по предложениям):");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
