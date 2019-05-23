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
    /// Interaktionslogik für Einzelansicht.xaml
    /// </summary>
    public partial class Einzelansicht : UserControl
    {
        private Spiel spiel { get; set; }
        public Einzelansicht()
        {
            InitializeComponent();
            MainWindow.Label.Content = "Einzelansicht";
            MainWindow.Zustand = MainWindow.Zustände.Detail;
            MainWindow.BackButton.Visibility = Visibility.Visible;
            DatenFüllen();
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

        private string CheckBoxConverter(bool istSteam)
        {
            if(istSteam)
            {
                return "Ja";
            }
            return "Nein";
        }

        private string DatumGenerieren(DateTime date)
        {
            return date.Date.ToString("d");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Ändernansicht());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog = MessageBox.Show("Dieses Element wirklich Löschen?", "Endgültig löschen?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(dialog == MessageBoxResult.Yes)
            {
                API.DeleteGame(MainWindow.AktuelleId);
                MainWindow.UCContainer.Children.Remove(this);
                MainWindow.UCContainer.Children.Add(new Listenansicht());
                MainWindow.BackButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
