﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120Projekt
{
    static class APIDemo
    {
        #region 

        // Create
        public static void DemoACreate()
        {
            Debug.Print("--- DemoACreate ---");
            // SpielBibliothek
            Data.SpielBibliothek SpielBibliothek1 = new Data.SpielBibliothek();
            SpielBibliothek1.Name = "Artikel 1";
            SpielBibliothek1.Publisher = "Ubisoft";
            SpielBibliothek1.Erscheinungsdatum = DateTime.Today;
            SpielBibliothek1.Mindestalter = 16;
            SpielBibliothek1.Preis = 77.99;
            SpielBibliothek1.IstSteam = false;
            SpielBibliothek1.Bewertung = 5;
            Int64 SpielBibliothek1Id = SpielBibliothek1.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + SpielBibliothek1Id);
        }
        public static void DemoACreateKurz()
        {
            Data.SpielBibliothek SpielBibliothek2 = new Data.SpielBibliothek { Name = "Artikel 2", IstSteam = true, Erscheinungsdatum = DateTime.Today };
            Int64 SpielBibliothek2Id = SpielBibliothek2.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + SpielBibliothek2Id);
        }

        // Read
        public static void DemoARead()
        {
            Debug.Print("--- DemoARead ---");
            // Demo liest alle
            foreach (Data.SpielBibliothek SpielBibliothek in Data.SpielBibliothek.LesenAlle())
            {
                Debug.Print("Artikel Id:" + SpielBibliothek.Id + " Name:" + SpielBibliothek.Name);
            }
        }
        // Update
        public static void DemoAUpdate()
        {
            Debug.Print("--- DemoAUpdate ---");
            // SpielBibliothek ändert Attribute
            Data.SpielBibliothek SpielBibliothek1 = Data.SpielBibliothek.LesenID(1);
            SpielBibliothek1.Name = "Artikel 1 nach Update";
            SpielBibliothek1.Aktualisieren();
        }
        // Delete
        public static void DemoADelete()
        {
            Debug.Print("--- DemoADelete ---");
            Data.SpielBibliothek.LesenID(1).Loeschen();
            Debug.Print("Artikel mit Id 1 gelöscht");
        }
        #endregion
    }
}
