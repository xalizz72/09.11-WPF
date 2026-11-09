using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace WpfApp7
{
    public partial class PageGallery : Page
    {
        public PageGallery()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            List<string> imagePaths = new List<string>();

      
            string folderPath = @"C:\Users\243450\source\repos\WpfApp7\WpfApp7\Images";

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*.*");

                foreach (string file in files)
                {
                    if (file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".webp"))
                    {
                        imagePaths.Add(System.IO.Path.GetFullPath(file));
                    }
                }
            }
            else
            {
                MessageBox.Show("Папка не найдена");
            }

            ImagesList.ItemsSource = imagePaths;
        }

        private void GoToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMenu());
        }
    }
}