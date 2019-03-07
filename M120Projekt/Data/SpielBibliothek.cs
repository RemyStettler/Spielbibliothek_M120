using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace M120Projekt.Data
{
    public class SpielBibliothek
    {
        #region Datenbankschicht
        [Key]
        public Int64 Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Publisher { get; set; }
        public String BildPfad { get; set; }
        [Required]
        public DateTime Erscheinungsdatum { get; set; }
        [Required]
        public Int64 Mindestalter { get; set; }
        [Required]
        public Double Preis { get; set; }
        [Required]
        public Boolean IstSteam { get; set; }
        [Required]
        public Int64 Bewertung { get; set; }
        #endregion
        #region Applikationsschicht
        public SpielBibliothek() { }
        [NotMapped]
        public String BerechnetesAttribut
        {
            get
            {
                return "Im Getter kann Code eingefügt werden für berechnete Attribute";
            }
        }
        public static IEnumerable<Data.SpielBibliothek> LesenAlle()
        {
            return (from record in Data.Global.context.SpielBibliothek select record);
        }
        public static Data.SpielBibliothek LesenID(Int64 SpielBibliothekId)
        {
            return (from record in Data.Global.context.SpielBibliothek where record.Id == SpielBibliothekId select record).FirstOrDefault();
        }
        public static IEnumerable<Data.SpielBibliothek> LesenAttributGleich(String suchbegriff)
        {
            return (from record in Data.Global.context.SpielBibliothek where record.Name == suchbegriff select record);
        }
        public static IEnumerable<Data.SpielBibliothek> LesenAttributWie(String suchbegriff)
        {
            return (from record in Data.Global.context.SpielBibliothek where record.Name.Contains(suchbegriff) select record);
        }
        public Int64 Erstellen()
        {
            if (this.Name == null || this.Name == "") this.Name = "leer";
            if (this.Erscheinungsdatum == null) this.Erscheinungsdatum = DateTime.MinValue;
            Data.Global.context.SpielBibliothek.Add(this);
            Data.Global.context.SaveChanges();
            return this.Id;
        }
        public Int64 Aktualisieren()
        {
            Data.Global.context.Entry(this).State = System.Data.Entity.EntityState.Modified;
            Data.Global.context.SaveChanges();
            return this.Id;
        }
        public void Loeschen()
        {
            Data.Global.context.Entry(this).State = System.Data.Entity.EntityState.Deleted;
            Data.Global.context.SaveChanges();
        }
        public override string ToString()
        {
            return Id.ToString(); // Für bessere Coded UI Test Erkennung
        }
        #endregion
    }
}
