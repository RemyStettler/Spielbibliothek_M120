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
    using Helpers;
    /// <summary>
    /// Interaktionslogik für Neuansicht.xaml
    /// </summary>
    public partial class Neuansicht : UserControl
    {
        private Validation validator;
        public Neuansicht()
        {
            InitializeComponent();
            validator = new Validation();
            MainWindow.Label.Content = "Neu";
            MainWindow.BackButton.Visibility = Visibility.Visible;
            MainWindow.Zustand = MainWindow.Zustände.Neu;
            btnNeu.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Listenansicht());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FelderLeeren();
        }

        private void FelderLeeren()
        {
            dateErscheinung.SelectedDate = null;
            dateErscheinung.DisplayDate = DateTime.Today;
            dateErscheinung.BorderBrush = new SolidColorBrush(Colors.Red);
            txtMindestalter.Clear();
            txtName.Clear();
            txtPreis.Clear();
            txtPublisher.Clear();
            txtBewertung.Clear();
            checkSteam.IsChecked = false;
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
                    btnNeu.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstName = false;
                btnNeu.IsEnabled = false;
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
                    btnNeu.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstPublisher = false;
                btnNeu.IsEnabled = false;
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
                    btnNeu.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstMindestalter = false;
                btnNeu.IsEnabled = false;
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
                    btnNeu.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstPreis = false;
                btnNeu.IsEnabled = false;
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
                    btnNeu.IsEnabled = true;
                }
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
                validator.IstBewertung = false;
                btnNeu.IsEnabled = false;
            }
        }

        private void BtnNeu_Click(object sender, RoutedEventArgs e)
        {
            Erstellen();
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Listenansicht());
        }

        private void Erstellen()
        {
            Console.WriteLine("--- Neues Objekt erstellen ---");
            Data.Spiel SpielBibliothek1 = new Data.Spiel();
            SpielBibliothek1.Name = txtName.Text;
            SpielBibliothek1.Publisher = txtPublisher.Text;
            SpielBibliothek1.Erscheinungsdatum = dateErscheinung.SelectedDate.Value.Date;
            SpielBibliothek1.Mindestalter = Convert.ToInt64(txtMindestalter.Text);
            SpielBibliothek1.Preis = double.Parse(txtPreis.Text);
            SpielBibliothek1.IstSteam = Helpers.CheckBoxConverter.ConvertCheckBox(checkSteam.IsChecked);
            SpielBibliothek1.Bewertung = Convert.ToInt64(txtBewertung.Text);
            SpielBibliothek1.created_at = DateTime.Today;
            Int64 SpielBibliothek1Id = SpielBibliothek1.Erstellen();
            Console.WriteLine("Spiel erstellt mit Id:" + SpielBibliothek1Id);
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
                    btnNeu.IsEnabled = true;
                }
            }
            else
            {
                datePicker.BorderBrush = Brushes.Red;
                validator.IstDatum = false;
                btnNeu.IsEnabled = false;
            }
        }
    }
}
