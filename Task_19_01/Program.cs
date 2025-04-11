namespace Task_19_01
{
    internal class Program
    {
        /* Напишите программу, в которой пользователь вводит произвольный текст в консоли, после чего
         * программа запрашивает подстроку для поиска. Если подстрока найдена - то программа запрашивает
         * текст для того чтобы заменить на него эту подстроку (столько раз, сколько раз подстрока
         * встречена в тексте)
         * Пример:
         * Введите строку: "Привет, мир!"
         * Введите подстроку для поиска: "мир"
         * Введите подстроку для замены: "друг"
         * Результат: "Привет, друг!"
         */
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputText = Console.ReadLine();

            Console.Write("Введите подстроку для поиска: ");
            string substringToFind = Console.ReadLine();

            // Проверка, содержится ли подстрока в тексте
            if (inputText.Contains(substringToFind))
            {
                Console.Write("Введите подстроку для замены: ");
                string substringToReplace = Console.ReadLine();

                // Замена всех вхождений найденной подстроки на новую подстроку
                string resultText = inputText.Replace(substringToFind, substringToReplace);

                Console.WriteLine($"Результат: \"{resultText}\"");
            }
            else
            {
                Console.WriteLine("Подстрока не найдена.");
            }
        }
    }
    
}
