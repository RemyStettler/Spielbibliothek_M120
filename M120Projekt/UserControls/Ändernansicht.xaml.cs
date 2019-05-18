using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M120Projekt.UserControls
{
    using Data;
    using Helpers;
    /// <summary>
    /// Interaktionslogik für Ändernansicht.xaml
    /// </summary>
    public partial class Ändernansicht : UserControl
    {
        private Validation validator;
        public Spiel spiel { get; set; }
        public Ändernansicht()
        {
            this.validator = new Validation { IstBewertung = true, IstDatum = true, IstMindestalter = true, IstName = true, IstPreis = true, IstPublisher = true };
            InitializeComponent();
            MainWindow.Label.Content = "Ändern";
            MainWindow.Zustand = MainWindow.Zustände.Ändern;
            DatenFüllen();
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Einzelansicht());
        }

        private void DatenFüllen()
        {
            spiel = API.GetGameById(MainWindow.AktuelleId);
            container.DataContext = spiel;
            //lblName.Content = spiel.Name;
            //lblPublisher.Content = spiel.Publisher;
            //lblErscheinung.Content = DatumGenerieren(spiel.Erscheinungsdatum);
            //lblMindestalter.Content = spiel.Mindestalter.ToString();
            //lblPreis.Content = spiel.Preis.ToString();
            //lblBewertung.Content = spiel.Bewertung.ToString();
            //lblSteam.Content = CheckBoxConverter(spiel.IstSteam);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Update();
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Einzelansicht());
        }

        private void Update()
        {
            Console.WriteLine("--- Spiel Update ---");
            // SpielBibliothek ändert Attribute
            Data.Spiel SpielBibliothek1 = Data.Spiel.LesenID(MainWindow.AktuelleId);
            SpielBibliothek1.Name = txtName.Text;
            SpielBibliothek1.Publisher = txtPublisher.Text;
            SpielBibliothek1.Erscheinungsdatum = dateErscheinung.SelectedDate.Value.Date;
            SpielBibliothek1.Mindestalter = Convert.ToInt64(txtMindestalter.Text);
            SpielBibliothek1.Preis = double.Parse(txtPreis.Text);
            SpielBibliothek1.IstSteam = Helpers.CheckBoxConverter.ConvertCheckBox(checkSteam.IsChecked);
            SpielBibliothek1.Bewertung = Convert.ToInt64(txtBewertung.Text);
            SpielBibliothek1.Aktualisieren();
            Console.WriteLine("--- Spiel Update fertig ---");
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (validator.NameValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
                validator.IstName = true;
                if (validator.Prüfen())
                {
                    btnSave.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstName = false;
                btnSave.IsEnabled = false;
            }

        }

        private void TxtPublisher_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (validator.PublisherValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
                validator.IstPublisher = true;
                if (validator.Prüfen())
                {
                    btnSave.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstPublisher = false;
                btnSave.IsEnabled = false;
            }
        }

        private void TxtMindestalter_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (validator.MindestalterValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
                validator.IstMindestalter = true;
                if (validator.Prüfen())
                {
                    btnSave.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstMindestalter = false;
                btnSave.IsEnabled = false;
            }
        }

        private void TxtPreis_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (validator.PreisValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
                validator.IstPreis = true;
                if (validator.Prüfen())
                {
                    btnSave.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstPreis = false;
                btnSave.IsEnabled = false;
            }
        }

        private void TxtBewertung_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (validator.BewertungValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
                validator.IstBewertung = true;
                if (validator.Prüfen())
                {
                    btnSave.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstBewertung = false;
                btnSave.IsEnabled = false;
            }
        }

        private void DateErscheinung_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            if (validator.DatumValidieren(datePicker))
            {
                datePicker.BorderBrush = Brushes.LightGreen;
                validator.IstDatum = true;
                if (validator.Prüfen())
                {
                    btnSave.IsEnabled = true;
                }
            }
            else
            {
                datePicker.BorderBrush = Brushes.Red;
                validator.IstDatum = false;
                btnSave.IsEnabled = false;
            }
        }
    }
}
