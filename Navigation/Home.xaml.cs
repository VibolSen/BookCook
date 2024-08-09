using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using BookCook.BookMenu;
using CookBook.BookMenu;

namespace CookBook
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }


        private void MainScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = sender as ScrollViewer;
            if (scrollViewer != null)
            {
                // Adjust the scroll speed factor
                double scrollSpeed = 3.0; // Increase or decrease this value for faster or slower scrolling
                if (e.Delta > 0)
                {
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta * scrollSpeed);
                }
                else
                {
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta * scrollSpeed);
                }
                e.Handled = true;
            }
        }

        private void AMok(object sender, System.Windows.RoutedEventArgs e)
        {
            AMok amokWindow = new AMok();
            amokWindow.Show();
        }

        private void SamlorKorkor(object sender, System.Windows.RoutedEventArgs e)
        {
            SamlorKorkor samlorkorkorWindow = new SamlorKorkor();
            samlorkorkorWindow.Show(); 
        }

        private void KuyTeav(object sender, System.Windows.RoutedEventArgs e)
        {
            KuyTeav kuyteave = new KuyTeav();
            kuyteave.Show();
        }

        private void NomBanhChok(object sender, System.Windows.RoutedEventArgs e)
        {
            NomBanhChok nomBanhChok = new NomBanhChok();
            nomBanhChok.Show();
        }

    }
}
