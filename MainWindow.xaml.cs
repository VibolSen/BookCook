using BookCook;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace CookBook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentArea.Content = new Banner();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Allow the user to drag the window by clicking and dragging
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            // Assuming Home is a UserControl or Window
            ContentArea.Content = new Home();
        }

        private void BrowserButton_Click(object sender, RoutedEventArgs e)
        {
            // Assuming Browser is a UserControl or Window
            ContentArea.Content = new Browser();
        }

        private void ForYouButton_Click(object sender, RoutedEventArgs e)
        {
            // Assuming ForYou is a UserControl or Window
            ContentArea.Content = new ForYou();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Add your logic for handling the text change event here
        }
    }

    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int length && length > 0)
                return Visibility.Collapsed;
            else
                return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
