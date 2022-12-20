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
                Console.WriteLine("Poprawnie zmieniono PIN, nowy PIN to {0}", k.getPIN());
            }
            else
            {
                Console.WriteLine("Błąd w zmianie PINu");
            }

            // Przykładowa wpłata
            if (k.setStanKonta(1000))
            {
                Console.WriteLine("Poprawnie zmieniono stan konta, nowy stan konta {0}", k.getStanKonta());
            }
            else
            {
                Console.WriteLine("Błąd w aktualizacji stanu konta");
            }
            
            // Przykładowa wypłata
            if (k.setStanKonta(-5000))
            {
                Console.WriteLine("Poprawnie zmieniono stan konta, nowy stan konta {0}", k.getStanKonta());
            }
            else
            {
                Console.WriteLine("Nie masz tylu pieniędzy!");
            }
        }    }
}