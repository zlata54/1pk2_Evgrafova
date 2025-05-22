using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Task_38_04
{
    /*Создайте окно для ввода информации о студенте (отдельно фамилия, имя , отчество, группа,
     * пол – перечисление, дата рождения (календарь))
     * При нажатии на кнопку «сохранить» данные о студенте сохраняются во внутренний список 
     * связанный с ListBox
     * При закрытии приложения данные сериализируются в файл
     */
    /// <summary>
    /// Перечисление для хранения пола студента
    /// </summary>
    public enum Gender
    {
        Мужской,
        Женский
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            private List<Student> students = new List<Student>();
            private const string FileName = "students.json";

         public MainWindow()
         {
             InitializeComponent();
             LoadStudents();
             lstStudents.ItemsSource = students;
             cmbGender.SelectedIndex = 0;
         }
        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Параметры события</param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
                if (!ValidateInputs())
                    return;

                var student = new Student
                {
                    LastName = txtLastName.Text.Trim(),
                    FirstName = txtFirstName.Text.Trim(),
                    MiddleName = txtMiddleName.Text.Trim(),
                    Group = txtGroup.Text.Trim(),
                    Gender = cmbGender.SelectedIndex == 0 ? Gender.Мужской : Gender.Женский,
                    BirthDate = dpBirthDate.SelectedDate ?? DateTime.Now
                };

                students.Add(student);
                lstStudents.Items.Refresh();

                ClearInputs();
                txtLastName.Focus();
        }
        /// <summary>
        /// Проверка корректности введенных данных
        /// </summary>
        /// <returns>True если данные корректны, иначе False</returns>
        private bool ValidateInputs()
        {
                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Фамилия обязательна для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtLastName.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("Имя обязательно для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtFirstName.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtGroup.Text))
                {
                    MessageBox.Show("Группа обязательна для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtGroup.Focus();
                    return false;
                }

                if (dpBirthDate.SelectedDate == null)
                {
                    MessageBox.Show("Укажите дату рождения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    dpBirthDate.Focus();
                    return false;
                }

                if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Zа-яА-ЯёЁ\-]+$"))
                {
                    MessageBox.Show("Фамилия может содержать только буквы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtLastName.Focus();
                    return false;
                }

                if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Zа-яА-ЯёЁ\-]+$"))
                {
                    MessageBox.Show("Имя может содержать только буквы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtFirstName.Focus();
                    return false;
                }

                if (!string.IsNullOrWhiteSpace(txtMiddleName.Text) &&
                    !Regex.IsMatch(txtMiddleName.Text, @"^[a-zA-Zа-яА-ЯёЁ\-]+$"))
                {
                    MessageBox.Show("Отчество может содержать только буквы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtMiddleName.Focus();
                    return false;
                }

                return true;
        }
        /// <summary>
        /// Очистка полей ввода
        /// </summary>
        private void ClearInputs()
        {
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtGroup.Clear();
                cmbGender.SelectedIndex = 0;
                dpBirthDate.SelectedDate = null;
        }
        /// <summary>
        /// Загрузка списка студентов из файла
        /// </summary>
        private void LoadStudents()
        {
                if (File.Exists(FileName))
                {
                    try
                    {
                        string json = File.ReadAllText(FileName);
                        students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}",
                            "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
        }
        /// <summary>
        /// Сохранение списка студентов в файл
        /// </summary>
        private void SaveStudents()
        {
                try
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string json = JsonSerializer.Serialize(students, options);
                    File.WriteAllText(FileName, json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }
        /// <summary>
        /// Обработчик события закрытия окна
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Параметры события</param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveStudents();
        }
        /// <summary>
        /// Обработчик ввода текста (валидация)
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Параметры события</param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Zа-яА-ЯёЁ\-]+$");
            e.Handled = !regex.IsMatch(e.Text);
        }
        
    }
}