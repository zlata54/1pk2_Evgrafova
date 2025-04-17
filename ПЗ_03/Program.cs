using System.Text.Json;

namespace ПЗ_03
{
    /*Создать перечисление категории важности заметки
     * Создать класс текстовой заметки (категория, дата создания, заголовок, текст заметки, вывод
     * информации по заметке).
     * Создать список заметок. Заполнить его программно через специальный метод-генератор
     * Создать статичный класс блокнота со статичными методами для:
     * 1. Добавления новой заметки
     * 2. Изменения категории уже существующей заметки
     * 3. Вывода заметок по времени создания
     * 4. Вывод заметок по категориям
     * 5. Вывод всех заметок с цветовой идентификацией: самые важные - красным цветом, и т.д.

     */
    public enum ImportanceCategory
    {
        Low,
        Medium,
        High  
    }
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main(string[] args)
        {
            Notebook.Initialize(); 

            // Основной цикл программы
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== БЛОКНОТ ===");
                Console.WriteLine("1. Просмотреть все заметки");
                Console.WriteLine("2. Добавить новую заметку");
                Console.WriteLine("3. Изменить категорию заметки");
                Console.WriteLine("4. Просмотреть по дате создания");
                Console.WriteLine("5. Просмотреть по категории");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("=== ВСЕ ЗАМЕТКИ ===");
                    Notebook.DisplayAllNotes();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("=== ДОБАВЛЕНИЕ ЗАМЕТКИ ===");

                    Console.Write("Введите заголовок: ");
                    string title = Console.ReadLine();

                    Console.Write("Введите содержание: ");
                    string content = Console.ReadLine();

                    Console.WriteLine("Выберите категорию:");
                    Console.WriteLine("1. Низкая");
                    Console.WriteLine("2. Средняя");
                    Console.WriteLine("3. Высокая");
                    Console.Write("Ваш выбор: ");

                    if (int.TryParse(Console.ReadLine(), out int categoryChoice) && categoryChoice >= 1 && categoryChoice <= 3)
                    {
                        ImportanceCategory category = (ImportanceCategory)(categoryChoice - 1);
                        // Создаем заметку с временным ID (0), реальный ID назначит AddNote
                        Note newNote = new Note(category, title, content, DateTime.Now, 0);
                        Notebook.AddNote(newNote);
                        Console.WriteLine("Заметка добавлена!");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный выбор категории!");
                    }
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("=== ИЗМЕНЕНИЕ КАТЕГОРИИ ===");
                    Notebook.DisplayAllNotes();

                    Console.Write("Введите ID заметки: ");
                    if (int.TryParse(Console.ReadLine(), out int noteId))
                    {
                        Console.WriteLine("Выберите новую категорию:");
                        Console.WriteLine("1. Низкая");
                        Console.WriteLine("2. Средняя");
                        Console.WriteLine("3. Высокая");
                        Console.Write("Ваш выбор: ");

                        if (int.TryParse(Console.ReadLine(), out int newCategory) && newCategory >= 1 && newCategory <= 3)
                        {
                            if (Notebook.ChangeNoteCategory(noteId, (ImportanceCategory)(newCategory - 1)))
                                Console.WriteLine("Категория изменена!");
                            else
                                Console.WriteLine("Заметка не найдена!");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный выбор категории!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ID!");
                    }
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("=== ЗАМЕТКИ ПО ДАТЕ СОЗДАНИЯ ===");
                    foreach (var note in Notebook.GetNotesByCreationDate())
                    {
                        note.DisplayInfo();
                    }
                }
                else if (choice == "5")
                {
                    Console.Clear();
                    Console.WriteLine("=== ФИЛЬТР ПО КАТЕГОРИИ ===");
                    Console.WriteLine("Выберите категорию:");
                    Console.WriteLine("1. Низкая");
                    Console.WriteLine("2. Средняя");
                    Console.WriteLine("3. Высокая");
                    Console.Write("Ваш выбор: ");

                    if (int.TryParse(Console.ReadLine(), out int categoryChoice) && categoryChoice >= 1 && categoryChoice <= 3)
                    {
                        Console.Clear();
                        Console.WriteLine($"=== ЗАМЕТКИ ({(ImportanceCategory)(categoryChoice - 1)}) ===");
                        foreach (var note in Notebook.GetNotesByCategory((ImportanceCategory)(categoryChoice - 1)))
                        {
                            note.DisplayInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный выбор категории!");
                    }
                }
                else if (choice == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный выбор!");
                }

                // Ожидаем нажатия любой клавиши для продолжения
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
