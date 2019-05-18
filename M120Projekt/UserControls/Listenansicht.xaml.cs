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
    /// <summary>
    /// Interaktionslogik für Listenansicht.xaml
    /// </summary>
    public partial class Listenansicht : UserControl
    {
        public Listenansicht()
        {
            InitializeComponent();
            MainWindow.Label.Content = "Listenansicht";
            MainWindow.Zustand = MainWindow.Zustände.List;
            Data.Global.context = new Data.Context();
            fillList();
        }

        public void fillList()
        {
            List<Spiel> games = API.GetAllGames();
            listGames.ItemsSource = games;
        }

        private void ListGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;
            if(list.SelectedItem != null)
            {
                Spiel spiel = (Spiel)list.SelectedItem;
                MainWindow.AktuelleId = spiel.Id;
                MainWindow.UCContainer.Children.Remove(this);
                MainWindow.UCContainer.Children.Add(new Einzelansicht());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Neuansicht());
        }
    }
}
