using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для PageSettings.xaml
    /// </summary>
    public partial class PageSettings : Page
    {
        // Путь к файлу (создастся в папке bin/Debug рядом с программой)
        private string filePath = "saved_text.txt";

        public PageSettings()
        {
            InitializeComponent();

        
            if (File.Exists(filePath))
            {
                InputTextBox.Text = File.ReadAllText(filePath);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
          
            File.WriteAllText(filePath, InputTextBox.Text);
            MessageBox.Show("Текст успешно сохранен!");
        }

        private void GoToMenu_Click(object sender, RoutedEventArgs e)
        {
       
            NavigationService.Navigate(new PageMenu());
        }
    }
}