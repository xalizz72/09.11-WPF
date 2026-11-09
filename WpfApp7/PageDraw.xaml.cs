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
    /// Логика взаимодействия для PageDraw.xaml
    /// </summary>
    public partial class PageDraw : Page
    {

        private Line currentLine;
        private Brush currentColor = Brushes.Black; // Цвет по умолчанию

        public PageDraw()
        {
            InitializeComponent();
        }

        // Кнопки выбора цвета
        private void SetRed_Click(object sender, RoutedEventArgs e) { currentColor = Brushes.Red; }
        private void SetGreen_Click(object sender, RoutedEventArgs e) { currentColor = Brushes.Green; }
        private void SetBlue_Click(object sender, RoutedEventArgs e) { currentColor = Brushes.Blue; }

        // Очистка холста
        private void ClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }

        // Выход в меню (из контекстного меню)
        private void GoToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMenu());
        }

        // Логика рисования (из конспекта)
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                currentLine = new Line();
                currentLine.Stroke = currentColor;
                currentLine.StrokeThickness = 2;

                Point p = e.GetPosition(DrawingCanvas);
                currentLine.X1 = p.X;
                currentLine.Y1 = p.Y;
                currentLine.X2 = p.X;
                currentLine.Y2 = p.Y;

                DrawingCanvas.Children.Add(currentLine);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && currentLine != null)
            {
                Point p = e.GetPosition(DrawingCanvas);
                currentLine.X2 = p.X;
                currentLine.Y2 = p.Y;
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            currentLine = null;
        }
    }
}