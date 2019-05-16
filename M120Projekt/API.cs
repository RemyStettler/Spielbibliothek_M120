using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120Projekt
{
    using Data;
    static class API
    {
        public static List<Spiel> getAllGames()
        {
            return Spiel.LesenAlle().ToList();
        }

        public static Spiel getGameById(long id)
        {
            return Spiel.LesenID(id);
        }

        public static List<Spiel> getGameSame(string filter)
        {
            return Spiel.LesenAttributGleich(filter).ToList();
        }

        public static List<Spiel> getGameLike(string filter)
        {
            return Spiel.LesenAttributWie(filter).ToList();
        }
        // Create
        public static void DemoACreate()
        {
            Debug.Print("--- DemoACreate ---");
            //SpielBibliothek
            Data.Spiel SpielBibliothek1 = new Data.Spiel();
            SpielBibliothek1.Name = "Artikel 1";
            SpielBibliothek1.Publisher = "Ubisoft";
            SpielBibliothek1.Erscheinungsdatum = DateTime.Today;
            SpielBibliothek1.Mindestalter = 16;
            SpielBibliothek1.Preis = 77.99;
            SpielBibliothek1.IstSteam = false;
            SpielBibliothek1.Bewertung = 5;
            SpielBibliothek1.created_at = DateTime.Today;
            Int64 SpielBibliothek1Id = SpielBibliothek1.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + SpielBibliothek1Id);
        }
        public static void DemoACreateKurz()
        {
            //Data.Spiel SpielBibliothek2 = new Data.Spiel { Name = "Artikel 2", IstSteam = true, Erscheinungsdatum = DateTime.Today };
            //Int64 SpielBibliothek2Id = SpielBibliothek2.Erstellen();
            //Debug.Print("Artikel erstellt mit Id:" + SpielBibliothek2Id);
        }

        // Read
        public static void DemoARead()
        {
            Debug.Print("--- DemoARead ---");
            // Demo liest alle
            foreach (Data.Spiel SpielBibliothek in Data.Spiel.LesenAlle())
            {
                Debug.Print("Artikel Id:" + SpielBibliothek.Id + " Name:" + SpielBibliothek.Name);
            }
        }
        // Update
        public static void DemoAUpdate()
        {
            Debug.Print("--- DemoAUpdate ---");
            // SpielBibliothek ändert Attribute
            Data.Spiel SpielBibliothek1 = Data.Spiel.LesenID(1);
            SpielBibliothek1.Name = "Artikel 1 nach Update";
            SpielBibliothek1.Aktualisieren();
        }
        // Delete
        public static void DemoADelete()
        {
            Debug.Print("--- DemoADelete ---");
            Data.Spiel.LesenID(1).Loeschen();
            Debug.Print("Artikel mit Id 1 gelöscht");
        }
    }
}
