using System.Collections.ObjectModel;
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
using Microsoft.Win32;
using System;
using System.IO;

namespace Task_39_02
{
    /*Создайте приложение – список покупок. Использовать ListBox. В качестве источника данных
     * использовать не List а ObservableCollection
     * Функции:
     * • Ввод продуктов
     * • Сохранение списка продуктов в текстовый файл
     * • Использовать стандартные диалоговые окна
     */

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Коллекция для хранения списка продуктов
        /// </summary>
        private ObservableCollection<string> products = new ObservableCollection<string>();

        /// <summary>
        /// Конструктор класса MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            lstProducts.ItemsSource = products;
        }
        /// <summary>
        /// Обработчик добавления нового продукта в список
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
                if (!string.IsNullOrWhiteSpace(txtProduct.Text))
                {
                    products.Add(txtProduct.Text);
                    txtProduct.Clear();
                    txtProduct.Focus();
                }
                else
                {
                    MessageBox.Show("Введите название продукта", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
        }
        /// <summary>
        /// Обработчик удаления выбранного продукта из списка
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
                if (lstProducts.SelectedItem != null)
                {
                    products.Remove(lstProducts.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Выберите продукт для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
        }
        /// <summary>
        /// Обработчик сохранения списка продуктов в файл
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
                if (products.Count == 0)
                {
                    MessageBox.Show("Список покупок пуст", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "Список покупок.txt";

                if (saveFileDialog.ShowDialog() == true)
                {
                    try
                    {
                        File.WriteAllLines(saveFileDialog.FileName, products);
                        MessageBox.Show("Список сохранен успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
        }
        /// <summary>
        /// Обработчик загрузки списка продуктов из файла
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == true)
                {
                    try
                    {
                        string[] loadedProducts = File.ReadAllLines(openFileDialog.FileName);
                        products.Clear();
                        foreach (string product in loadedProducts)
                        {
                            products.Add(product);
                        }
                        MessageBox.Show("Список загружен успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
        }
    }
}
