using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            zahlRaten();
            Methode1Einfuehrung();
            Method2ArraysUndSchleifen();

        }

        private static void Method2ArraysUndSchleifen()
        {
            int[] zahlen = new int[4];
            zahlen[0] = 1;
            zahlen[2] = 7;
            string[] produkte = { "Handy", "Taschenlampe", "Maus" };

            if(produkte[0] == "Handy" || produkte[0].Equals("Handy"))
            {
                Console.WriteLine("Ja ein Handy");
            }

            switch (produkte[0])
            {
                case "Handy":
                    Console.WriteLine("war ein Handy");
                    break;
                case "Maus":
                    Console.WriteLine("war Maus");
                    break;
            }

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine($"zahl: {zahlen[i]}");
            }
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }

            //Zahlerate spiel
            // Computer überlegt sich eine zufällige Zahl (0 bis 100) Randok
            //max. 10 mal die Möglichkeit einen Tipp abzugeben
            //Beispiel zufällige Zahl ist 37
            //1. Tipp --> 50
            //Ihre Eingabe ist höher als die zufällige Zahl
            //Oje- Sie aben die Zahl nicht erraten
            //Super - Sie haben die Zal nach 3 Versuchen erraten
            //for -- 0  .. 9 break;
            //do while(ZahlNichtErraten und Versuche kleiner 10) --

           
        }

        private static void zahlRaten()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int versuch = 0;
            int guessedNumber;

            do
            {
                Console.WriteLine("Guess one number 1-100");

                guessedNumber = int.Parse(Console.ReadLine());

                if (number == guessedNumber)
                    Console.WriteLine("Gratuliere, du bist super");

                else if (number < guessedNumber)
                {
                    Console.WriteLine("Number is smaller");
                }
                else if (number > guessedNumber)
                    Console.WriteLine("Number is bigger, like your mama");

                else
                Console.WriteLine("Du hast es verkackt");

                versuch++;


            } while (versuch < 10 || number == guessedNumber);
               

        }

        private static void Methode1Einfuehrung()
        {

            //lokale Variablen deklarieren
            string firstName; // string ist Alias für System.String
            int plz = 0; // int ist ein Alias für System.Int32

            System.String lastName = "Sandez";
            System.Int32 streetNumber;

            double plzDbl = 0;
            plzDbl = plz;
            plz = (int)plzDbl;

            plzDbl = double.MaxValue;

            checked
            {
                try
                {
                    plz = (int)plzDbl;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ein Fehler {ex} ist aufgetreten");
                }

            }

            Console.WriteLine("Hello World!");

            Console.WriteLine("Wie heißen Sie?");

            firstName = Console.ReadLine();

            plz = int.Parse(Console.ReadLine());

            Console.WriteLine("Hallo und herzlich willkommen " + firstName);
            Console.WriteLine("Hallo {0} {1} herzlich willkommen ", firstName, lastName);
            Console.WriteLine($"Hallo {firstName} {lastName} herzlich willkommen {plz}");
        }
    }
}
