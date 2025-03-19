namespace Task_14_04
{
    /*Определите класс User, который будет иметь статическое свойство CurrentUser, представляющее
     * текущего пользователя, и метод для его установки.
     */
    internal class User
    {
        public string Name; // Имя пользователя
        public string Email; // Электронная почта пользователя

        private static User currentUser; // Статическое поле для хранения текущего пользователя

        /// <summary>
        /// Получает текущего пользователя.
        /// </summary>
        public static User CurrentUser
        {
            get { return currentUser; }
        }

        /// <summary>
        /// Устанавливает текущего пользователя.
        /// </summary>
        /// <param name="user">Пользователь, которого нужно установить текущим.</param>
        public static void SetCurrentUser(User user)
        {
            currentUser = user;
            Console.WriteLine($"Текущий пользователь: {currentUser.Name}");
        }

        /// <summary>
        /// Выводит информацию о пользователе, включая имя и электронную почту.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Email: {Email}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание нового пользователя
            User user1 = new User();
            user1.Name = "Иван";
            user1.Email = "ivan@mail.com";

            // Установка текущего пользователя и вывод текущей информации о нем
            User.SetCurrentUser(user1);

            if (User.CurrentUser != null)
            {
                User.CurrentUser.GetInfo();
            }

            // Создание другого пользователя, установка другого пользователя как текущего и вывод информации о текущем пользователе
            User user2 = new User();
            user2.Name = "Мария";
            user2.Email = "maria@mail.com";

            User.SetCurrentUser(user2);

            if (User.CurrentUser != null)
            {
                User.CurrentUser.GetInfo();
            }
        }
    }
}
