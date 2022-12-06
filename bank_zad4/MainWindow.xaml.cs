using System.Windows;

namespace bank_zad4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Hidden;
            nowyUz.Visibility = Visibility.Visible;
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Visible;
            nowyUz.Visibility = Visibility.Hidden;
        }
    }
}