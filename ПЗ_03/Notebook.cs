using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ПЗ_03
{
    /// <summary>
    /// Статический класс для работы с блокнотом заметок
    /// </summary>
    public static class Notebook
    {
        private static List<Note> notes = new List<Note>();
        private static string dataFile = "notes.json";
        private static int nextId = 1; // Счетчик для генерации новых ID

        /// <summary>
        /// Инициализирует блокнот (загружает данные или создает тестовые)
        /// </summary>
        public static void Initialize()
        {
            if (File.Exists(dataFile))
            {
                // Загружаем данные из файла
                string json = File.ReadAllText(dataFile);
                notes = JsonSerializer.Deserialize<List<Note>>(json);

                // Устанавливаем nextId как максимальный ID + 1
                nextId = notes.Count > 0 ? notes.Max(n => n.Id) + 1 : 1;
            }
            else
            {
                notes = NoteGenerator.GenerateNotes(5);
                nextId = notes.Count > 0 ? notes.Max(n => n.Id) + 1 : 1;
                SaveNotes();
            }
        }

        /// <summary>
        /// Сохраняет все заметки в файл
        /// </summary>
        private static void SaveNotes()
        {
            // Сериализуем список заметок в JSON с отступами
            string json = JsonSerializer.Serialize(notes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFile, json);
        }

        /// <summary>
        /// Добавляет новую заметку в блокнот
        /// </summary>
        /// <param name="note">Заметка для добавления</param>
        public static void AddNote(Note note)
        {
            note.Id = nextId++;
            notes.Add(note);
            SaveNotes();
        }

        /// <summary>
        /// Изменяет категорию существующей заметки
        /// </summary>
        /// <param name="noteId">ID заметки для изменения</param>
        /// <param name="newCategory">Новая категория</param>
        /// <returns>True, если изменение прошло успешно, иначе False</returns>
        public static bool ChangeNoteCategory(int noteId, ImportanceCategory newCategory)
        {
            // Ищем заметку по ID
            Note note = notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)
            {
                note.Category = newCategory;
                SaveNotes();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Возвращает заметки, отсортированные по дате создания
        /// </summary>
        /// <returns>Отсортированный список заметок</returns>
        public static List<Note> GetNotesByCreationDate()
        {
            return notes.OrderBy(n => n.CreatedDate).ToList();
        }

        /// <summary>
        /// Возвращает заметки указанной категории
        /// </summary>
        /// <param name="category">Категория для фильтрации</param>
        /// <returns>Список заметок указанной категории</returns>
        public static List<Note> GetNotesByCategory(ImportanceCategory category)
        {
            return notes.Where(n => n.Category == category).ToList();
        }

        /// <summary>
        /// Выводит все заметки в консоль
        /// </summary>
        public static void DisplayAllNotes()
        {
            foreach (var note in notes)
            {
                note.DisplayInfo();
            }
        }
    }
}
