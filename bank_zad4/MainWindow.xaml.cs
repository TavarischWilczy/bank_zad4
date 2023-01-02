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
            Start.Visibility = Visibility.Hidden;
            NowyUz.Visibility = Visibility.Visible;
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Start.Visibility = Visibility.Visible;
            NowyUz.Visibility = Visibility.Hidden;
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            Klient.imie = Imie.Text;
            var nazwisko = Nazwosko.Text;
            var nr_konta = NumerKonta.Text;
            if (nr_konta.Length > 4)
            {
                MessageBox.Show("Unable to save file, try again.", "Save error");
            }
            else
            {
                
            }
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}