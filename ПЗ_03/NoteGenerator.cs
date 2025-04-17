using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_03
{
    /// <summary>
    /// Статический класс для генерации тестовых заметок
    /// </summary>
    public static class NoteGenerator
    {
        /// <summary>
        /// Генерирует указанное количество тестовых заметок
        /// </summary>
        /// <param name="count">Количество заметок для генерации</param>
        /// <returns>Список сгенерированных заметок</returns>
        public static List<Note> GenerateNotes(int count)
        {
            List<Note> notes = new();
            Random random = new();

            List<string> titles = new List<string>
        {
            "Какие книги нужно прочитать в январе",
            "Какие книги нужно прочитать в феврале",
            "Какие книги нужно прочитать в марте",
            "Какие книги нужно прочитать в апреле",
            "Какие книги нужно прочитать в мае",
        };

            List<string> contents = new List<string>
        {
            "'Преступление и наказание' Достоевского, 'Мастер и Маргарита' Булгакова",
            "'Гордость и предубеждение' Остин, 'Убить пересмешника' Харпер Ли",
            "'Анна Каренина' Толстого, 'Великий Гэтсби' Фицджеральда",
            "'451 градус по Фаренгейту' Брэдбери, 'Темные аллеи' Бунина",
            "'По ту сторону весов' Накамуры, 'Братья Карамазовы' Достоевского"
        };

            // Локальная функция для генерации случайной даты (за последние 6 месяцев)
            DateTime GetRandomDate()
            {
                DateTime start = DateTime.Now.AddMonths(-6); // Начальная дата (6 месяцев назад)
                int range = (DateTime.Now - start).Days;     // Диапазон в днях
                return start.AddDays(random.Next(range));    // Случайная дата в диапазоне
            }

            // Генерация заданного количества заметок
            for (int i = 0; i < count; i++)
            {
                // Выбираем случайные значения для заметки
                ImportanceCategory category = (ImportanceCategory)random.Next(0, 3);
                int index = random.Next(titles.Count);
                string title = titles[index];
                string content = contents[index];
                DateTime createdDate = GetRandomDate();

                int id = notes.Count == 0 ? 1 : notes.Last().Id + 1;

                Note note = new Note(category, title, content, createdDate, id);
                notes.Add(note);
            }

            return notes;
        }
    }
}
