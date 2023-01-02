using System.Windows;

namespace bank_zad4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Nowy obiekt klienta
            Klient k = new Klient("Jan", "Kowalski", "123123123");
            // Przykładowa zmiana PINu
            if (k.setPin("4141")) // k.setPin("12345") zwróci false
            {
                MessageBox.Show("Poprawnie zmieniono PIN, nowy PIN to " + k.getPIN(), "Close");
            }
            else
            {
                MessageBox.Show("Błąd w zmianie PINu", "Close");
            }

            // Przykładowa wpłata
            if (k.setStanKonta(1000))
            {
                MessageBox.Show("Poprawnie zmieniono stan konta, nowy stan konta " + k.getStanKonta(), "Close");
            }
            else
            {
                MessageBox.Show("Błąd w aktualizacji stanu konta", "Close");
            }
            
            // Przykładowa wypłata
            if (k.setStanKonta(-5000))
            {
                MessageBox.Show("Poprawnie zmieniono stan konta, nowy stan konta " + k.getStanKonta(), "Close");
            }
            else
            {
                MessageBox.Show("Nie masz tylu pieniędzy!", "Close");
            }
        }    }
}