namespace Task_23_06
{
    internal class Program
    {
        /*Напишите программу со следующими функциями:
         * 1. Выведите информации о всех дисках в системе
         * 2. Выведите содержимое каталога C:\Users (названия папок)
         * 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
         * a) Создание вложенного каталога “temp”
         * b) Вывод информации о текущем каталоге (имя, родитель и тд)
         * c) Вывод информации о вложенном каталоге
         * 4. Переместите каталог “temp” по пути “D:\work\newTemp”
         * a) Реализуйте вывод информационного сообщения об успешном (или нет) перемещении
         * 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении.
         */
        static void Main()
        {
            // 1. Вывод информации о всех дисках в системе
            Console.WriteLine("Информация о дисках:");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine($"Диск {d.Name} ({d.DriveType}), " +
                    $"ФС: {d.DriveFormat}, " +
                    $"Свободно: {d.TotalFreeSpace / (1024 * 1024 * 1024)} GB");
            }
            Console.WriteLine();

            // 2. Вывод содержимого каталога C:\Users
            Console.WriteLine("Содержимое C:\\Users:");
            DirectoryInfo usersDir = new DirectoryInfo(@"C:\Users");
            if (usersDir.Exists)
            {
                List<DirectoryInfo> userDirs = usersDir.GetDirectories().ToList();
                foreach (DirectoryInfo dir in userDirs)
                {
                    Console.WriteLine($"- {dir.Name}");
                }
            }
            Console.WriteLine();

            // 3. Создание папки work на диске D и работа с ней
            string workPath = @"D:\work";
            DirectoryInfo workDir = new DirectoryInfo(workPath);

            if (!workDir.Exists)
            {
                workDir.Create();
                Console.WriteLine($"Создана папка: {workPath}");
            }

            // 3a) Создание вложенного каталога temp
            string tempPath = Path.Combine(workPath, "temp");
            DirectoryInfo tempDir = new DirectoryInfo(tempPath);
            if (!tempDir.Exists)
            {
                tempDir.Create();
                Console.WriteLine($"Создана папка: {tempPath}");
            }

            // 3b) Вывод информации о текущем каталоге (work)
            Console.WriteLine("\nИнформация о каталоге work:");
            Console.WriteLine($"Имя: {workDir.Name}\n" +
                $"Полный путь: {workDir.FullName}\n" +
                $"Родительский каталог: {workDir.Parent?.Name}\n" +
                $"Дата создания: {workDir.CreationTime}\n" +
                $"Последнее обращение: {workDir.LastAccessTime}");

            // 3c) Вывод информации о вложенном каталоге (temp)
            Console.WriteLine("\nИнформация о каталогах в work:");
            List<DirectoryInfo> workSubDirs = workDir.GetDirectories().ToList();
            foreach (DirectoryInfo subDir in workSubDirs)
            {
                Console.WriteLine($"{subDir.Name} - {subDir.FullName}\n" +
                    $"\tДата создания: {subDir.CreationTime}\n" +
                    $"\tКорневой каталог: {subDir.Parent?.Name}\n" +
                    $"\tПоследнее обращение: {subDir.LastAccessTime}");
            }

            // 4. Перемещение каталога temp в newTemp
            string newTempPath = @"D:\work\newTemp";
            try
            {
                if (Directory.Exists(tempPath) && !Directory.Exists(newTempPath))
                {
                    Directory.Move(tempPath, newTempPath);
                    Console.WriteLine($"\nКаталог успешно перемещен из {tempPath} в {newTempPath}");
                }
                else
                {
                    Console.WriteLine("\nОшибка перемещения: исходный каталог не существует или целевой уже существует");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка при перемещении: {ex.Message}");
            }

            // 5. Попытка удаления каталога temp (если он остался)
            try
            {
                if (Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath, true);
                    Console.WriteLine($"\nКаталог {tempPath} успешно удален");
                }
                else
                {
                    Console.WriteLine($"\nКаталог {tempPath} не существует, удаление не требуется");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка при удалении: {ex.Message}");
            }
        }
    }
}
