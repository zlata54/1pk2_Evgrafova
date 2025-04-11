namespace Task_20_05
{
    internal class Program
    {
        /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
         * • Guest (только чтение)
         * • User (чтение + комментарии)
         * • Moderator (удаление контента)
         * • Admin (полный доступ)
         * Создайте метод, который проверяет, может ли пользователь выполнить действие (например,
         * удалитьпост).
         * На основе уровня доступа выводите сообщение (например,"Ошибка: Недостаточно прав!").
         */
        static void Main(string[] args)
        {
            Console.Write("Введите ваш уровень доступа (Guest, User, Moderator, Admin): ");
            string input = Console.ReadLine();

            if (Enum.TryParse<AccessLevel>(input, true, out var accessLevel))
            {
                DisplayAvailableActions(accessLevel);
                AttemptToDeletePost(accessLevel);
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный уровень доступа.");
            }
        }
        /// <summary>
        /// Отображает доступные действия в зависимости от уровня доступа пользователя.
        /// </summary>
        /// <param name="accessLevel">Уровень доступа пользователя.</param>
        static void DisplayAvailableActions(AccessLevel accessLevel)
        {
            Console.WriteLine("Доступные действия:");

            switch (accessLevel)
            {
                case AccessLevel.Guest:
                    Console.WriteLine("- Чтение контента");
                    Console.WriteLine("Ошибка: Вы не можете писать комментарии или удалять контент.");
                    Console.WriteLine("Ошибка: Вы не можете выполнять административные действия.");
                    break;

                case AccessLevel.User:
                    Console.WriteLine("- Чтение контента");
                    Console.WriteLine("- Оставлять комментарии");
                    Console.WriteLine("Ошибка: Вы не можете удалять контент.");
                    Console.WriteLine("Ошибка: Вы не можете выполнять административные действия.");
                    break;

                case AccessLevel.Moderator:
                    Console.WriteLine("- Чтение контента");
                    Console.WriteLine("- Оставлять комментарии");
                    Console.WriteLine("- Удалять контент");
                    Console.WriteLine("Ошибка: Вы не можете выполнять административные действия.");
                    break;

                case AccessLevel.Admin:
                    Console.WriteLine("- Чтение контента");
                    Console.WriteLine("- Оставлять комментарии");
                    Console.WriteLine("- Удалять контент");
                    Console.WriteLine("Вы обладаете полным доступом.");
                    break;

                default:
                    Console.WriteLine("Ошибка: Недействительный уровень доступа.");
                    break;
            }
        }
        /// <summary>
        /// Пытается удалить пост в зависимости от уровня доступа пользователя
        /// и выводит соответствующее сообщение.
        /// </summary>
        /// <param name="accessLevel">Уровень доступа пользователя.</param>
        static void AttemptToDeletePost(AccessLevel accessLevel)
        {
            Console.WriteLine("\nПопытка удалить пост:");
            if (CanDeletePost(accessLevel))
            {
                Console.WriteLine("Пост успешно удалён.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для удаления поста!");
            }
        }
        /// <summary>
        /// Проверяет, имеет ли пользователь право удалять посты.
        /// </summary>
        /// <param name="accessLevel">Уровень доступа пользователя.</param>
        /// <returns>True, если пользователь может удалить пост; в противном случае — false.</returns>
        static bool CanDeletePost(AccessLevel accessLevel)
        {
            return accessLevel == AccessLevel.Moderator || accessLevel == AccessLevel.Admin;
        }
    }
}
