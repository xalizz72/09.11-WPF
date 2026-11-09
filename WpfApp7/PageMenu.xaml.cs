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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }
        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            bool v = NavigationService.Navigate(new PageDraw());
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageSettings());
        }

        private void BtnGallery_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageGallery());
        }
    }
}