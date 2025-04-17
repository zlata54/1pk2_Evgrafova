using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_03
{
    /// <summary>
    /// Класс, представляющий текстовую заметку
    /// </summary>
    public class Note
    {
        // Свойства заметки
        public ImportanceCategory Category { get; set; }
        public DateTime CreatedDate { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// Конструктор для создания новой заметки
        /// </summary>
        /// <param name="category">Категория важности</param>
        /// <param name="title">Заголовок заметки</param>
        /// <param name="content">Содержание заметки</param>
        /// <param name="createdDate">Дата создания</param>
        /// <param name="id">Идентификатор заметки</param>
        public Note(ImportanceCategory category, string title, string content, DateTime createdDate, int id)
        {
            Category = category;
            Title = title;
            Content = content;
            CreatedDate = createdDate;
            Id = id;
        }

        /// <summary>
        /// Выводит информацию о заметке в консоль с цветовым оформлением
        /// </summary>
        public void DisplayInfo()
        {
            // Устанавливаем цвет текста в зависимости от категории
            Console.ForegroundColor = GetCategoryColor();
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Заголовок: {Title}");
            Console.WriteLine($"Содержание: {Content}");
            Console.WriteLine($"Категория: {Category}");
            Console.WriteLine($"Дата создания: {CreatedDate:g}");
            Console.ResetColor();
            Console.WriteLine(new string('-', 40));
        }

        // Возвращает цвет консоли в зависимости от категории заметки
        private ConsoleColor GetCategoryColor()
        {
            return Category switch
            {
                ImportanceCategory.High => ConsoleColor.Red,
                ImportanceCategory.Medium => ConsoleColor.Yellow,
                ImportanceCategory.Low => ConsoleColor.Green,
                _ => ConsoleColor.White
            };
        }
    }
}
